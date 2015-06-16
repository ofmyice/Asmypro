using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    public class ConfigInfo:BasisInfo
    {
        /// <summary>
        /// 筛选条件注册地
        /// </summary>
        public string RegArea { get; set; }
    }
}
