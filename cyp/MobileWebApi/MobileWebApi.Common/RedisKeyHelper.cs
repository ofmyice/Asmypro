using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    /// <summary>
    /// RedisKey获取
    /// </summary>
    public class RedisKeyHelper
    {
        private const string Platform = "WebAPI:2015:";
        /// <summary>
        /// 用户权限Key
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns></returns>
        public static string UserRights(string businessId)
        {
            return string.Concat(Platform, "BusinessID:", businessId);
        }
    }
}
