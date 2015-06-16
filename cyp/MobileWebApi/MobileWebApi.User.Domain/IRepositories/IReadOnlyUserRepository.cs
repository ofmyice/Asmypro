using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.User.Domain.DataModel;

namespace MobileWebApi.User.Domain.IRepositories
{
    public interface IReadOnlyUserRepository
    {
        /// <summary>
        /// 获取用户出价。观看权限城市
        /// </summary>
        /// <param name="businessid"></param>
        /// <returns></returns>
        IList<UserRight> GetUserRights(string businessid);
    }
}
