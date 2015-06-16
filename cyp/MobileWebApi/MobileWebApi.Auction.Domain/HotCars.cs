using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileWebApi.Auction.Domain
{
    public class HotCars
    {
        /// <summary>
        /// 首图
        /// </summary>
        public string CarFirstImg { get; set; }
        /// <summary>
        /// 车辆描述
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        public string Rank { get; set; } 
    }
}
