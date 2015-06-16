using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Auctions.Domain
{
    public class Auction
    {
        /// <summary>
        /// 竞拍ID
        /// </summary>
        public int AucId { get; set; }
        /// <summary>
        /// 车辆ID
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// 车辆描述
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// 车辆平级
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// 首图
        /// </summary>
        public string CarFirstImg { get; set; }
        /// <summary>
        /// 车辆编码
        /// </summary>
        public string TradeCode { get; set; }
        /// <summary>
        /// 报告导入平台标识
        /// </summary>
        public int WayTag { get; set; }
        /// <summary>
        /// 车牌
        /// </summary>
        public string License { get; set; }
        /// <summary>
        /// 行车号
        /// </summary>
        public string LicenseModel { get; set; }
        /// <summary>
        /// 所在地
        /// </summary>
        public string RegArea { get; set; }
        /// <summary>
        /// 初登日期
        /// </summary>
        public string RegDate { get; set; }
        /// <summary>
        /// 排放标准
        /// </summary>
        public string EmissionStandard { get; set; }
        /// <summary>
        /// 合手价
        /// </summary>
        public decimal FinalOffer { get; set; }
        /// <summary>
        /// 外迁合手价
        /// </summary>
        public decimal FinalOfferNonlocal { get; set; }
        /// <summary>
        /// 竞拍结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 竞拍类型
        /// </summary>
        public int AucRootTag { get; set; }
    }
}
