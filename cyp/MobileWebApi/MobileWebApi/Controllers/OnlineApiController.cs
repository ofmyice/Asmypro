using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.Impl;

namespace MobileWebApi.Controllers
{
    /// <summary>
    /// 封装ApiController
    /// </summary>
    public class OnlineApiController : Controller
    {
        /// <summary>
        /// 在线ID
        /// </summary>
        public string OnlineID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string BusinessID { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 客户端类型 0-安卓 1-苹果手机 3 andriodPad 4 IOS pad 
        /// </summary>
        public string ClientType { get; set; }

        public OnlineApiController()
        {
            SetPro(System.Web.HttpContext.Current);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
        /// <summary>
        /// 设置属性
        /// </summary>
        /// <param name="context"></param>
        private void SetPro(HttpContext context)
        {
            OnlineID = string.IsNullOrEmpty(context.Request["onlineid"]) ? "" : context.Request["onlineid"].ToString();
            if (!string.IsNullOrEmpty(context.Request["businessid"]))
            {
                try
                {
                    BusinessID = Common.DesEncodeHelper.DESDeCode(context.Request["businessid"].ToString(),
                        Common.DesEncodeHelper.Key);
                }
                catch
                {

                    BusinessID = context.Request["businessid"].ToString();
                }
            }
            Version = string.IsNullOrEmpty(context.Request["version"]) ? "" : context.Request["version"].ToString();
            ClientType = string.IsNullOrEmpty(context.Request["clienttype"]) ? "" : context.Request["clienttype"].ToString();
        }

        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            try
            {
                if (System.Web.HttpContext.Current == null) return "";
                return System.Web.HttpContext.Current.Request[key];
            }
            catch
            {

                return "";
            }
        }
    }
}