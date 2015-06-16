using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    /// <summary>
    /// 在用户使用的时候获取代金币信息
    /// </summary>
    public class VoucherUseInfo:BasisInfo
    {
        public VoucherUseInfo()
        {
            this.PtVoucher=new Voucher();
            this.QyVoucher=new Voucher();
            this.TyVoucher=new Voucher();
        }
        /// <summary>
        /// 平台通用代金币
        /// </summary>
        public Voucher PtVoucher { get; set; }
        /// <summary>
        /// 区域特约代金币
        /// </summary>
        public Voucher QyVoucher { get; set; }
        /// <summary>
        /// 通用特约代金币
        /// </summary>
        public Voucher TyVoucher { get; set; }
    }
}
