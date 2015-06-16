using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Order.Domian;
using MobileWebApi.Order.Service.WcfOrderService;
using Newtonsoft.Json;

namespace MobileWebApi.Order.Service.Impl
{
    public class CompleteOrderService : ICompleteOrderService
    {
        /// <summary>
        /// Pad已成交列表
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="orderstatus">订单状态 0全部,30 代付款 50 代验车,60 带过户.80 交易成功 100交易关闭</param>
        /// <param name="auctype">交易类型  0全部,1 快拍 2易拍 3 专场</param>
        /// <param name="thisyear"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public string GetDealCarListForPad(string businessid, string orderstatus, string auctype, string thisyear, string pageindex, string pagesize)
        {
            ComleteOrderInfo comleteOrderInfo=new ComleteOrderInfo();
            WcfOrderService.OrderModel order = new OrderModel();
           // order.Items= new WcfOrder[27];
            int busid = Convert.ToInt32(businessid);
            int status = Convert.ToInt32(orderstatus);
            int isthisyear = Convert.ToInt32(thisyear);
            int longbid = -1;
            if (auctype.Equals("1"))
            {//快拍
                longbid = 0;
            }
            if (auctype.Equals("2"))
            {//易拍
                longbid = 1;
            }
            using (WcfOrderService.WcfOrderServiceClient c=new WcfOrderServiceClient())
            {
                 order = c.GetDealCarList(busid,
                    status, isthisyear, "", longbid,
                    Convert.ToInt32(pagesize),Convert.ToInt32(pageindex),Config.TokenKey);
            }

            comleteOrderInfo.SetState(ResState.Success);
            comleteOrderInfo.Data = order.Items;
            comleteOrderInfo.TotalCount = order.TotalCount.ToString();
            return JsonConvert.SerializeObject(comleteOrderInfo);

        }
        /// <summary>
        /// 价格查询
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="orid"></param>
        /// <param name="carmodel">车型</param>
        /// <param name="countryId">国别1中国 2 进口</param>
        /// <param name="brandName">品牌</param>
        /// <param name="manufacturerName">厂商</param>
        /// <param name="seriesName">车系</param>
        /// <param name="pzgear">变速箱0 全部 1 自动 2 手动</param>
        /// <param name="isNqs">0 查询 1 点击热门关键字</param>
        /// <returns></returns>
        public string GetPriceSearchList(string businessid, string orid, string carmodel, string countryId, string brandName,
            string manufacturerName, string seriesName, string pzgear, string isNqs,string userlevel,string emssion)
        {
            PriceSearchInfo priceSearchInfo=new PriceSearchInfo();
            PriceSearchCarDataInfo priceSearchCarDataInfo=new PriceSearchCarDataInfo();
            WcfOrderService.SearchModel searchModel=new SearchModel();
            int _busid = Convert.ToInt32(businessid);
            int _buyerlevel = Convert.ToInt32(userlevel);
            int _orid = Convert.ToInt32(orid);
            int _countryid = Convert.ToInt32(countryId);
            int _pzgear = Convert.ToInt32(pzgear);
            int _isseries = Convert.ToInt32(isNqs);
            using (WcfOrderService.WcfOrderServiceClient c = new WcfOrderServiceClient())
            {
                searchModel = c.GetCarPriceSearchList(_busid, _buyerlevel, _orid, _countryid, brandName,
                    manufacturerName, seriesName,_pzgear,50,_isseries,Config.TokenKey,emssion);
                if (searchModel.IsSuccess)
                {
                    priceSearchInfo.SetState(ResState.Success);
                    priceSearchCarDataInfo.free = searchModel.Free;
                    priceSearchCarDataInfo.result = searchModel.MsgReturn;
                    priceSearchCarDataInfo.lst = searchModel.Items;
                }
            }
            priceSearchInfo.Data = priceSearchCarDataInfo;
            return JsonConvert.SerializeObject(priceSearchInfo);
        }
        /// <summary>
        /// 获取交易关闭原因
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="aucid"></param>
        /// <returns></returns>
        public string GetOrderCloseDesc(string orderid, string aucid)
        {
            OrderCloseInfo orderCloseInfo=new OrderCloseInfo();
            using (WcfOrderService.WcfOrderServiceClient c = new WcfOrderServiceClient())
            {
                orderCloseInfo.CloseDesc=c.GetTradeoffMsg(orderid, Convert.ToInt32(aucid));
                orderCloseInfo.SetState(ResState.Success);
            }
           
            return JsonConvert.SerializeObject(orderCloseInfo);
        }
        /// <summary>
        /// 订单车辆
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="rootTag"></param>
        /// <param name="orderStatus"></param>
        /// <param name="markTime"></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public string GetOrderCarList(int businessId, int aucRootTag, int orderStatus, int markTime, string searchTxt,
            int pageSize, int pageIndex)
        {
            OrderCars result = new OrderCars();
            #region
            using (WcfOrderService.WcfOrderServiceClient c = new WcfOrderServiceClient())
            {
                var returnData = c.GetOrderCarList(businessId, aucRootTag,orderStatus, markTime, searchTxt, pageSize,
                    pageIndex, Config.TokenKey);
                result.Data = returnData.DataList;
                result.TotalCount = returnData.TotalCount;
                result.SetState(ResState.Success);
            }
            #endregion
            return JsonConvert.SerializeObject(result);
        }
        /// <summary>
        /// 获取历史竞价车辆
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="aucRootTag"></param>
        /// <param name="markTime"></param>
        /// <param name="caseType"></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public string GetBidHistoryList(int businessId, int aucRootTag, int markTime, int caseType, string searchTxt,
            int pageSize, int pageIndex)
        {
            HistoryBid result = new HistoryBid();
            #region
            using (WcfOrderService.WcfOrderServiceClient c = new WcfOrderServiceClient())
            {
                var returnData = c.GetBidHistoryList(businessId, aucRootTag, markTime, caseType, searchTxt, pageSize,
                    pageIndex,Config.TokenKey);
                result.Data = returnData.DataList;
                result.TotalCount = returnData.TotalCount;
                result.SetState(ResState.Success);
            }
            #endregion
            return JsonConvert.SerializeObject(result);
        }
        /// <summary>
        /// 获取待确认车辆
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="aucRootTag"></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public string GetUnConfirmCarList(int businessId, int aucRootTag, string searchTxt, int pageSize,
            int pageIndex)
        {
            UnConfirmCars result = new UnConfirmCars();
            #region
            using (WcfOrderService.WcfOrderServiceClient c = new WcfOrderServiceClient())
            {
                var returnData = c.GetUnConfirmCarList(businessId, aucRootTag, searchTxt, pageSize, pageIndex, Config.TokenKey);
                result.Data = returnData.DataList;
                result.TotalCount = returnData.TotalCount;
                result.SetState(ResState.Success);
            }
            return JsonConvert.SerializeObject(result);
            #endregion

        }
    }
}
