using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.MVC;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.Impl;

namespace MobileWebApi.Controllers
{
    /// <summary>
    /// 资产中心
    /// </summary>
    
    [MyAuth]
    public class CapitalController : OnlineApiController
    {
        private readonly IUserAccountService _userAccountService;
        public CapitalController()
        {
            _userAccountService = ServiceLocator.Current.GetInstance<IUserAccountService>();
        }
        /// <summary>
        /// 资产中心首页数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return Content(_userAccountService.GetCapitalIndex(BusinessID));
        }
        /// <summary>
        /// 获取保证金信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetEarnestInfo()
        {
            return Content(_userAccountService.GetEarnestInfo(BusinessID));
        }
        /// <summary>
        /// 保证金收支记录
        /// </summary>
        /// <returns></returns>
        public ActionResult GetEarnestLogList()
        {
            //datetype 1 一个月内 2 三个月内 3 一年内
            string datetype = string.IsNullOrWhiteSpace(GetValue("datetype"))?"0":GetValue("datetype");
            //tag  0 充值  1扣款 2 全部
            string tag = string.IsNullOrWhiteSpace(GetValue("tag"))?"2":GetValue("tag");
            string pageIndex =string.IsNullOrWhiteSpace(GetValue("pageIndex"))?"1": GetValue("pageIndex");
            string pageSzie = string.IsNullOrWhiteSpace(GetValue("pageSize"))?"10":GetValue("pageSize");
            var beginTime = new DateTime(2000, 1, 1);
            switch (datetype)
            {
                case "1":
                    beginTime = DateTime.Now.AddMonths(-1);
                    break;
                case "2":
                    beginTime = DateTime.Now.AddMonths(-3);
                    break;
                case "3":
                    beginTime = DateTime.Now.AddYears(-1);
                    break;
            }
            return Content(_userAccountService.GetEarnestLogList(BusinessID,beginTime,tag,pageIndex,pageSzie ));
        }
        /// <summary>
        /// 获取代金币总额
        /// </summary>
        /// <returns></returns>
        public ActionResult GetVoucherInfo()
        {
            return Content(_userAccountService.GetVoucherInfo(BusinessID));
        }
        /// <summary>
        /// 代金币使用界面获取代金币总额
        /// </summary>
        /// <returns></returns>
        public ActionResult GetVoucherInfoInUse()
        {
            //需要支付车款的carid
            string carid = GetValue("carid");
            return Content(_userAccountService.GetVoucherInfoInUse(BusinessID,carid));
        }
        /// <summary>
        /// 获取代金币收支记录
        /// </summary>
        /// <returns></returns>
        public ActionResult GetVoucherLogList()
        {
            //0 全部 1 收入2 支出
            string type = string.IsNullOrWhiteSpace(GetValue("type")) ? "0" : GetValue("type");
            string pageIndex = string.IsNullOrWhiteSpace(GetValue("pageIndex")) ? "1" : GetValue("pageIndex");
            string pageSzie = string.IsNullOrWhiteSpace(GetValue("pageSize")) ? "10" : GetValue("pageSize");
            return Content(_userAccountService.GetVoucherLogList(BusinessID,type,pageIndex,pageSzie));
        }
        /// <summary>
        /// 获取商信通信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSxtInfo()
        {
            return Content(_userAccountService.GetBusinessSxtInfo(BusinessID));
        }
        /// <summary>
        /// 获取商信通还款列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSxtList()
        {
            string pageIndex = string.IsNullOrWhiteSpace(GetValue("pageIndex")) ? "1" : GetValue("pageIndex");
            string pageSzie = string.IsNullOrWhiteSpace(GetValue("pageSize")) ? "10" : GetValue("pageSize");
            return Content(_userAccountService.GetSxtList(BusinessID,pageIndex,pageSzie));
        }
    }
}
