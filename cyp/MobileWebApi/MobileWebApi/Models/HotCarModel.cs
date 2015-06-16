using MobileWebApi.Auctions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileWebApi.Common;

namespace MobileWebApi.Models
{
    public  class HotCarModel
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
        /// <summary>
        /// 车辆编码
        /// </summary>
        public string TradeCode { get; set; }
        /// <summary>
        /// 报告导入平台标识
        /// </summary>
        public int WayTag { get; set; }
        /// <summary>
        /// 排放标准
        /// </summary>
        public string EmissionStandard { get; set; }

    }

    public class ModelView:BasisInfo
    {
        public object KYPai { get; set; }
        public List<HotCarModel> KuaiPai { get; set; }
        public List<HotCarModel> YiPai { get; set; }
    }

    public static class BindModel
    {
        public static ModelView BindList(this ModelView result, IList<Auction> kpList, IList<Auction> ypList)
        {
            List<HotCarModel> kp = new List<HotCarModel>();
            List<HotCarModel> yp = new List<HotCarModel>();
            foreach (var auc in kpList)
            {
                kp.Add(new HotCarModel().ConvertToModel(auc));
            }
            foreach (var auc in ypList)
            {
                yp.Add(new HotCarModel().ConvertToModel(auc));
            }
            result.KuaiPai = kp;
            result.YiPai = yp;
            result.SetState(ResState.Success);
            return result;
        }
        public static ModelView BindList(this ModelView result, IList<Auction> list,int auctionType)
        {
            List<HotCarModel> items = new List<HotCarModel>();
            foreach (var auc in list)
            {
                items.Add(new HotCarModel().ConvertToModel(auc));
            }
            if (auctionType == 1)
            {
                result.KuaiPai = items;
            }
            else if(auctionType==2)
            {
                result.YiPai = items;
            }
            result.SetState(ResState.Success);
            return result;
        }

        public static HotCarModel ConvertToModel(this HotCarModel car ,Auction auction)
        {
            car.AucId = auction.AucId;
            car.CarId = auction.CarId;
            car.CarFirstImg = auction.CarFirstImg;
            car.Rank = auction.Rank;
            car.Model = auction.Model;
            car.TradeCode = auction.TradeCode;
            car.WayTag = auction.WayTag;
            car.EmissionStandard = auction.EmissionStandard;
            return car;
        }
    }
}