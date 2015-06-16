using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MobileWebApi.Common;
using Newtonsoft.Json;
using NLog;

namespace MobileWebApi.MVC
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class CypErrorAttribute : HandleErrorAttribute
    {
        
        public override void OnException(ExceptionContext filterContext)
        {
            Logger globalErrorLog = LogManager.GetCurrentClassLogger();
            var paras = filterContext.HttpContext.Request == null
                ? string.Empty
                : filterContext.HttpContext.Request.Form.ToString();
                string UID=HttpContext.Current.Request["businessid"] ?? "";
            //记录错误
            string error = string.Format("BusinessId：{0}\r\n Exceptions：{1}。\r\n Params：{2}",
                (Common.DesEncodeHelper.DESDeCode(UID, Common.DesEncodeHelper.Key)), filterContext.Exception.ToString(),
                HttpContext.Current.Request.Url);
            globalErrorLog.Error(error);
            //发送邮件
            Common.MailHelper.Send(error);
            //给客户端提示
            var erroeData = new BasisInfo();
            filterContext.Result=new ContentResult(){Content = JsonConvert.SerializeObject(erroeData),ContentEncoding =Encoding.Default,ContentType = "json"};
            filterContext.ExceptionHandled = true;
            base.OnException(filterContext);
        }
    }
}