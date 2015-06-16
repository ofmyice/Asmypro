using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Order.Domian;

namespace MobileWebApi.Order.Service
{
    public interface ICompleteOrderService
    {
        /// <summary>
        /// Pad已成交列表
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="orderstatus"></param>
        /// <param name="auctype"></param>
        /// <param name="thisyear"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        string GetDealCarListForPad(string businessid, string orderstatus, string auctype, string thisyear,
            string pageindex, string pagesize);

        /// <summary>
        /// 价格查询
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="orid"></param>
        /// <param name="carmodel"></param>
        /// <param name="countryId"></param>
        /// <param name="brandName"></param>
        /// <param name="manufacturerName"></param>
        /// <param name="seriesName"></param>
        /// <param name="pzgear"></param>
        /// <param name="isNqs"></param>
        /// <param name="userlevel"></param>
        /// <param name="emssion"></param>
        /// <returns></returns>
        string GetPriceSearchList(string businessid, string orid, string carmodel, string countryId, string brandName,
            string manufacturerName, string seriesName, string pzgear, string isNqs,string userlevel,string emssion);
       /// <summary>
       /// 获取交易关闭原因
       /// </summary>
       /// <param name="orderid"></param>
       /// <param name="aucid"></param>
       /// <returns></returns>
        string GetOrderCloseDesc(string orderid, string aucid);
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
        string GetOrderCarList(int businessId, int aucRootTag, int orderStatus, int markTime, string searchTxt,
            int pageSize, int pageIndex);
        /// <summary>
        /// 历史竞价
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="aucRootTag"></param>
        /// <param name="markTime"></param>
        /// <param name="caseType"></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        string GetBidHistoryList(int businessId, int aucRootTag, int markTime, int caseType, string searchTxt,
            int pageSize, int pageIndex);
        /// <summary>
        /// 获取待确认车辆
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="aucRootTag"></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        string GetUnConfirmCarList(int businessId, int aucRootTag, string searchTxt, int pageSize, int pageIndex);

    }
}
