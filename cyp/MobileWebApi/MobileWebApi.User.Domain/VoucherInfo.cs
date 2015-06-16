using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    public class VoucherInfo:BasisInfo
    {
        /// <summary>
        /// 通用代金币
        /// </summary>
        public int GeneralVoucher { get; set; }
        /// <summary>
        /// 特约代金币
        /// </summary>
        public int ContributeVoucher { get; set; }
        /// <summary>
        /// 通用特约代金币
        /// </summary>
        public int GenContributeVoucher { get; set; }
    }
}
