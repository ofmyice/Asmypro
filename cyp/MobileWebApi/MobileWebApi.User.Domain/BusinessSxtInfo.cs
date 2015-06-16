using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    public class BusinessSxtInfo:BasisInfo
    {
        public BusinessSxtInfo()
        {
            IsSXT = false;
        }
        /// <summary>
        /// 是否是商信通用户
        /// </summary>
        public bool IsSXT { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public int TotalLoan { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public int LeftLoan { get; set; }
        /// <summary>
        /// 冻结金额
        /// </summary>
        public int FrezeLoan { get; set; }
    }
}
