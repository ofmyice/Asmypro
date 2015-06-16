using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileWebApi.Common;
namespace MobileWebApi.Special.Domain
{
    public class ComprehensiveInfo: BasisInfo
    {
        //public T Data { get; set; }
        public object Data { get; set; }

        /// <summary>
        /// 待确认车辆
        /// </summary>
        public int UnConfirmCar { get; set; }
        /// <summary>
        /// 待付款车辆
        /// </summary>
        public decimal UnPayment { get; set; }
        /// <summary>
        /// 待验车
        /// </summary>
        public int UnCheckCar { get; set; }
        /// <summary>
        /// 交易完成
        /// </summary>
        public int Complete { get; set; }
        /// <summary>
        /// 总代金币
        /// </summary>
        public int TotalVoucher { get; set; }
        /// <summary>
        /// 总保证金
        /// </summary>
        public decimal TotalMoney { get; set; }
        /// <summary>
        /// Logo路径
        /// </summary>
        public string LogoPath { get; set; }
        /// <summary>
        /// 为完成任务
        /// </summary>
        public int UnCompleteTask { get; set; }
    }
}
