using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Misc.Service;
using MobileWebApi.Misc.Service.Impl;
using MobileWebApi.MVC;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.Impl;

namespace MobileWebApi.Controllers
{
   
    
    public class LoginController : OnlineApiController
    {
        private readonly IUserLoginService _userLoginService;
        private readonly ILogMessageService _logMessageService;
        public LoginController()
        {
            _userLoginService = ServiceLocator.Current.GetInstance<IUserLoginService>();
            _logMessageService = ServiceLocator.Current.GetInstance<ILogMessageService>();
        }
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <returns></returns>
        [MyAuth]
        public ActionResult GetConfig()
        {
            string content = _userLoginService.GetConfigInfo();
            return Content(content);
        }
        /// <summary>
        /// 记录微信分享信息
        /// </summary>
        /// <returns></returns>
        [MyAuth]
        public ActionResult LogShare()
        {
            string tradecode = GetValue("tradecode");
            string pagefrom = GetValue("pagefrom");
            string shareto = GetValue("shareto");
            return Content(_logMessageService.LogShare(BusinessID, tradecode, pagefrom, shareto));
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            string userName = GetValue("username");
            string passWord = GetValue("password");
            string imei = GetValue("imei");
            //string clienttype = GetValue("clienttype");
            string forceLogin = string.IsNullOrWhiteSpace(GetValue("focelogin")) ? "0" : GetValue("focelogin");
            string provinceName = GetValue("ProvinceName");
            string cityName = GetValue("CityName");
            string areaName = GetValue("AreaName");
            string streetName = GetValue("StreetName");
            return
                Content(_userLoginService.Login(userName, passWord, imei, ClientType, forceLogin, provinceName, cityName,
                    areaName, streetName,Version));
        }
    }
}