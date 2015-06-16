using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CYP.RedisService;

namespace MobileWebApi.Common.DbHelpers
{
    public class RedisBaseRepository
    {
        protected static readonly RedisClientManager RedisManger = RedisManager.GetInstance().Create("RedisConnectionString");

        //Redis开关
        protected static bool RedisSwitch = ConfigurationManager.AppSettings["RedisSwitch"] != null
            ? Convert.ToBoolean(ConfigurationManager.AppSettings["RedisSwitch"].ToString())
            : false;
    }
}
