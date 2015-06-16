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
    /// 提供给商户端和后台的调用推送接口
    /// </summary>
    public class PushController : OnlineApiController
    {
        private readonly IPushMessageService _pushMessageService;

        public PushController()
        {
            _pushMessageService = ServiceLocator.Current.GetInstance<IPushMessageService>();
        }
        /// <summary>
        /// 给商户端和后台调用的推送通知接口
        /// </summary>
        /// <returns></returns>
        [MyAuth]
        public ActionResult Index()
        {
            string messagetype = GetValue("MessageType");//11：智能报价,12:交易成功,13:交易失败,14:系统公告
            string uidList = GetValue("Uids");
            string msg = GetValue("info");
            string tokenkey = GetValue("tokenkey");
            if (!Common.Config.TokenKey.Equals(tokenkey)) return Content("");
            _pushMessageService.PushMessage(uidList,messagetype,msg);
            return Content("");
        }
    }
}
