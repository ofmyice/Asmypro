using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    /// <summary>
    /// 保证金信息
    /// </summary>
    public class EarnestInfo:BasisInfo
    {
        /// <summary>
        /// 保证金总金额
        /// </summary>
        public int TotalMoney { get; set; }
        /// <summary>
        /// 冻结金额
        /// </summary>
        public int FreezeMoney { get; set; }
        /// <summary>
        /// 剩余金额
        /// </summary>
        public int BlanceMoney { get; set; }
        /// <summary>
        /// 冻结车辆数量
        /// </summary>
        public int FreezeCarNum { get; set; }
    }
}
