using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Common.DbHelpers;
using MobileWebApi.User.Domain.DataModel;

namespace MobileWebApi.User.Data.RedisRepositories
{
    public class RedisUserLoginRepository : RedisBaseRepository
    {
        #region===用户权限缓存
        public static List<UserRight> GetUserRightsRedis(string businessid)
        {
            if (!RedisSwitch) //开关关闭，则返回空
                return null;

            try
            {
                using (var client = RedisManger.GetReadwriteClient())
                {
                    return client.Get<List<UserRight>>(RedisKeyHelper.UserRights(businessid));
                }
            }
            catch
            {
                return null;
            }
        }
        public static void SetUserRightsRedis(List<UserRight> list,string businessid)
        {
            if (!RedisSwitch) return ;
            try
            {
                using (var client = RedisManger.GetReadwriteClient())
                {
                     client.Set(RedisKeyHelper.UserRights(businessid), list, DateTime.Now.AddMinutes(15));
                }
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
