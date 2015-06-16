using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.User.Service;

namespace MobileWebApi.Controllers
{
    /// <summary>
    /// 设置相关控制器
    /// </summary>
    public class SettingController : OnlineApiController
    {
        private readonly IUserSettingService _settingService;

        public SettingController()
        {
            _settingService = ServiceLocator.Current.GetInstance<IUserSettingService>();
        }
        /// <summary>
        /// 获取短信设置
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSmsSettingInfo()
        {
            return Content(_settingService.GetSmsSettingInfo(BusinessID));
        }

        /// <summary>
        /// 获取短信设置
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveSmsSetting()
        {
            string cjdx = string.IsNullOrWhiteSpace(GetValue("Cjdx")) ? "0" : GetValue("Cjdx");
            string tzdx = string.IsNullOrWhiteSpace(GetValue("Tzdx")) ? "0" : GetValue("Tzdx");
            string sbdx = string.IsNullOrWhiteSpace(GetValue("Sbdx")) ? "0" : GetValue("Sbdx");
            string spdx = string.IsNullOrWhiteSpace(GetValue("Spdx")) ? "0" : GetValue("Spdx");
            return Content(_settingService.SaveSmsSetting(BusinessID,cjdx,tzdx,sbdx,spdx));
        }

    }
}
