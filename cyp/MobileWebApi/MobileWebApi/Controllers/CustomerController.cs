using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Misc.Service;
using MobileWebApi.Misc.Service.Impl;
using MobileWebApi.MVC;

namespace MobileWebApi.Controllers
{
    /// <summary>
    /// 客服中心
    /// </summary>
    [MyAuth]
    public class CustomerController : OnlineApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = ServiceLocator.Current.GetInstance<ICustomerService>();
        }
        /// <summary>
        /// 获取提车点信息列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetCarPositionList()
        {
            return Content(_customerService.GetCarPositionList());
        }
        /// <summary>
        /// 添加建议反馈
        /// </summary>
        /// <returns></returns>
        public ActionResult SetSuggestion()
        {
            string msg = GetValue("message");
            string msgtype = GetValue("msgtype");
            string phonenum = GetValue("phonenum");
            return Content(_customerService.SetSuggestion(BusinessID, msg, msgtype, phonenum));
        }
    }
}
