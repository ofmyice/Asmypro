using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.MVC;
using MobileWebApi.Order.Service;
using MobileWebApi.Common;

namespace MobileWebApi.Controllers
{
    
    [MyAuth]
    public class OrderController : OnlineApiController
    {
        private readonly ICompleteOrderService _completeOrderService;
        public OrderController()
        {
            _completeOrderService = ServiceLocator.Current.GetInstance<ICompleteOrderService>();
                
        }
        /// <summary>
        /// Pad已成交列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDealCarListForPad()
        {
            //车辆状态 0全部,30 代付款 50 代验车,60 待过户.80 交易成功 100交易关闭
            string status = string.IsNullOrEmpty(GetValue("Status")) ? "0" : GetValue("Status");
            //交易类型  0全部,1 快拍 2易拍 3 专场
            string aucType = string.IsNullOrEmpty(GetValue("AucType")) ? "0" : GetValue("AucType");
            //交易时间
            string timeSpan = string.IsNullOrEmpty(GetValue("TimeSpan")) ? "1" : GetValue("TimeSpan");
            string pageSize = string.IsNullOrEmpty(GetValue("pagesize")) ? "30" : GetValue("pagesize");
            string pageindex = string.IsNullOrEmpty(GetValue("pageindex")) ? "1" : GetValue("pageindex");
            return Content(_completeOrderService.GetDealCarListForPad(BusinessID, status, aucType, timeSpan, pageindex, pageSize));
        }
        /// <summary>
        /// 价格查询-精确查询
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPriceSearchlist()
        {
            //车型
            string carModel = GetValue("carModel");
            //区域
            string orid = GetValue("orId");
            //国家
            string countryName = GetValue("countryId");
            //品牌
            string brand = GetValue("brandName");
            //厂商
            string mf = GetValue("manufacturerName");
            //变速箱
            string isPzgear = GetValue("pzgear");
            if (string.IsNullOrEmpty(isPzgear))
            {
                isPzgear = "0";
            }
            //用户等级
            string userlevel = GetValue("userlevel");
            if (string.IsNullOrEmpty(userlevel))
            {
                userlevel = "0";
            }

            //在哪点击
            string isNqs = GetValue("isNqs");
            if (string.IsNullOrEmpty(isNqs))
            {
                isNqs = "0";
            }
            //车系
            string series = GetValue("seriesName");
           
            //排放标准
            string emission = GetValue("emission");
            if (string.IsNullOrEmpty(emission))
            {
                emission = "";
            }
            return Content(_completeOrderService.GetPriceSearchList(BusinessID,orid,carModel,countryName,brand,mf,series,isPzgear,isNqs,userlevel,emission));
        }

        /// <summary>
        /// 获取交易关闭原因
        /// </summary>
        /// <returns></returns>
        public ActionResult GetOrderCloseDesc()
        {
            //车辆状态 0全部,30 代付款 50 代验车,60 待过户.80 交易成功 100交易关闭
            string orderid = string.IsNullOrEmpty(GetValue("OrderID")) ? "0" : GetValue("OrderID");
            //交易类型  0全部,1 快拍 2易拍 3 专场
            string aucid = string.IsNullOrEmpty(GetValue("Aucid")) ? "0" : GetValue("Aucid");
            return Content(_completeOrderService.GetOrderCloseDesc(orderid,aucid));
        }
        /// <summary>
        /// 获取待确认车辆
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUnConfirmCarList()
        {
            int businessId =0;
            businessId=ToolBox.ToSaveInt(BusinessID);
            int aucRootTag = string.IsNullOrEmpty(GetValue("aucRootTag")) ? 0 : ToolBox.ToSaveInt(GetValue("aucRootTag"));
            string searchTxt = string.IsNullOrEmpty(GetValue("searchTxt")) ? "" : GetValue("searchTxt");
            int pageIndex = string.IsNullOrEmpty(GetValue("pageIndex")) ? 1 : ToolBox.ToSaveInt(GetValue("pageIndex"));
            int pageSize = string.IsNullOrEmpty(GetValue("pageSize")) ? 30 : ToolBox.ToSaveInt(GetValue("pageSize"));
            return Content(_completeOrderService.GetUnConfirmCarList(businessId, aucRootTag,searchTxt, pageSize, pageIndex));
        }
        /// <summary>
        /// 获取历史竞价车辆
        /// </summary>
        /// <returns></returns>
        public ActionResult GetBidHistoryList()
        {
            int businessId = 0;
            businessId = ToolBox.ToSaveInt(BusinessID);
            int aucRootTag = string.IsNullOrEmpty(GetValue("aucRootTag")) ? 0 : ToolBox.ToSaveInt(GetValue("aucRootTag"));
            int markTime = string.IsNullOrEmpty(GetValue("markTime")) ? 0 : ToolBox.ToSaveInt(GetValue("markTime"));
            string searchTxt = string.IsNullOrEmpty(GetValue("searchTxt")) ? "" : GetValue("searchTxt");
            int pageIndex = string.IsNullOrEmpty(GetValue("pageIndex")) ? 1 : ToolBox.ToSaveInt(GetValue("pageIndex"));
            int pageSize = string.IsNullOrEmpty(GetValue("pageSize")) ? 30 : ToolBox.ToSaveInt(GetValue("pageSize"));
            return Content(_completeOrderService.GetBidHistoryList(businessId, aucRootTag, markTime, 0, searchTxt, pageSize, pageIndex));
        }
        /// <summary>
        /// 获取订单车辆
        /// </summary>
        /// <returns></returns>
        public ActionResult GetOrderCarList()
        {
            int businessId = 0;
            businessId = ToolBox.ToSaveInt(BusinessID);
            int aucRootTag = string.IsNullOrEmpty(GetValue("aucRootTag")) ? 0 : ToolBox.ToSaveInt(GetValue("aucRootTag"));
            int markTime = string.IsNullOrEmpty(GetValue("markTime")) ? 0 : ToolBox.ToSaveInt(GetValue("markTime"));
            int orderStatus = string.IsNullOrEmpty(GetValue("orderStatus")) ? 0 : ToolBox.ToSaveInt(GetValue("orderStatus"));
            string searchTxt = string.IsNullOrEmpty(GetValue("searchTxt")) ? "" : GetValue("searchTxt");
            int pageIndex = string.IsNullOrEmpty(GetValue("pageIndex")) ? 1 : ToolBox.ToSaveInt(GetValue("pageIndex"));
            int pageSize = string.IsNullOrEmpty(GetValue("pageSize")) ? 30 : ToolBox.ToSaveInt(GetValue("pageSize"));
            return Content(_completeOrderService.GetOrderCarList(businessId, aucRootTag,orderStatus,markTime, searchTxt, pageSize, pageIndex));
        }
    }
}
