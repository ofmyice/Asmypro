using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using MobileWebApi.User.Data.Assembers;
using MobileWebApi.Common;
using MobileWebApi.Common.DbHelpers;
using MobileWebApi.User.Data.RedisRepositories;
using MobileWebApi.User.Domain.DataModel;
using MobileWebApi.User.Domain.IRepositories;

namespace MobileWebApi.User.Data
{
    public class ReadOnlyUserRepository : ReadOnlyBaseRepository,IReadOnlyUserRepository
    {
        /// <summary>
        /// 获取用户出价权限
        /// </summary>
        /// <param name="businessid"></param>
        /// <returns></returns>
        public IList<UserRight> GetUserRights(string businessid)
        {
            List<UserRight> list = null;
            list = RedisUserLoginRepository.GetUserRightsRedis(businessid);
            if (list != null) return list;
            string sql = @"SELECT  Orid, ModeTag, OperTag ,BusinessScreenName AS  OrName
FROM    tbBusiness_OperORID BOO(NOLOCK)
INNER JOIN dbo.tbOrganize_Root ORT(NOLOCK) ON BOO.orid = ORT.id and BOO.DeleteTag=0
WHERE   businessid = @UID
AND ORT.businessDisplayTag = 1
ORDER BY ordernum, orid, modetag, opertag";
            SqlParameter[]pars=
            {
                new SqlParameter("@UID",businessid) 
            };
            var ds = SqlHelper.ExecuteDataset(ReadOnlyConn, CommandType.Text, sql, pars);
            if(ds.IsNullOrEmpty()) return new List<UserRight>();
            var result = new List<UserRight>().SetByDataTable(ds.Tables[0]);
            RedisUserLoginRepository.SetUserRightsRedis(result.ToList(),businessid);
            return result;
        }
    }
}
