using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.Impl;

namespace MobileWebApi.MVC
{
    /// <summary>
    /// 身份验证过滤器
    /// </summary>
    public class MyAuthAttribute:AuthorizeAttribute
    {
        /// <summary>
        /// 验证授权
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //是否开启在线验证
            bool onlineJudge = Convert.ToBoolean(ConfigurationManager.AppSettings["OnlineJudge"]);
            if (onlineJudge)
            {
                var memberValidation = System.Web.HttpContext.Current.Request["onlineid"];
                IUserLoginService _userLoginService = new UserLoginService();
                if (!_userLoginService.CheckIsOnline(memberValidation))
                {
                    HandleUnauthorizedRequest(filterContext);
                }
            }
        }
        /// <summary>
        /// 判断在线
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        //protected override bool AuthorizeCore(HttpContextBase httpContext)
        //{
        //    ////获取Cookies中的Login
        //    //var memberValidation = System.Web.HttpContext.Current.Request["onlineid"];
        //    //IUserLoginService _userLoginService = new UserLoginService();
        //    //if (!_userLoginService.CheckIsOnline(memberValidation))
        //    //{
        //    //    HttpContext.Current.Response.Write("-10100");
        //    //    HttpContext.Current.Response.End();
        //    //    return true;
        //    //}
        //    //return false;
        //}
        /// <summary>
        /// 授权失败
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ContentResult(){ContentType = "json",Content = "-10010",ContentEncoding = Encoding.Default};
        }
    }
}