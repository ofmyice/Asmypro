using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileWebApi.Misc.Service;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Common;
using MobileWebApi.Models;
using MobileWebApi.MVC;

namespace MobileWebApi.Controllers
{
    [MyAuth]
    public class MessageController : OnlineApiController
    {
       private readonly IMessageService _messageService;
       public MessageController()
        {
            _messageService = ServiceLocator.Current.GetInstance<IMessageService>();
        }
        public ActionResult GetMessageList()
        {
            string tokenkey = GetValue("tokenkey");
            int businessId = ToolBox.ToSaveInt(BusinessID);
            int pageIndex=ToolBox.ToSaveInt(GetValue("pageIndex"));
            int pageSize = ToolBox.ToSaveInt(GetValue("pageSize"));
            if (!Common.Config.TokenKey.Equals(tokenkey))
            {
                return Content("");
            }
            var result = _messageService.GetMessageList(businessId,pageIndex,pageSize);
            return Content(result);
        }

        public ActionResult GetNoticeList()
        {
            string tokenkey = GetValue("tokenkey");
            int pageIndex=ToolBox.ToSaveInt(GetValue("pageIndex"));
            int pageSize = ToolBox.ToSaveInt(GetValue("pageSize"));
            if (!Common.Config.TokenKey.Equals(tokenkey))
            {
                return Content("");
            }
            var result = _messageService.GetNoticeList(pageIndex,pageSize);
            return Content(result);
        }

        public ActionResult GetMessageById()
        {
            string tokenkey = GetValue("tokenkey");
            int id = ToolBox.ToSaveInt(GetValue("id"));
            if (!Common.Config.TokenKey.Equals(tokenkey))
            {
                return Content("");
            }
            var result = _messageService.GetMessageById(id);
            return Content(result);
        }

        public ActionResult GetMsgStateCount()
        {
            string tokenkey = GetValue("tokenkey");            
            if (!Common.Config.TokenKey.Equals(tokenkey))
            {
                return Content("");
            }
            int businessId = ToolBox.ToSaveInt(BusinessID);
            int showTagType = ToolBox.ToSaveInt(GetValue("showTagType"));
            int readType = ToolBox.ToSaveInt(GetValue("readType"));
            int msgType = ToolBox.ToSaveInt(GetValue("msgType"));
            return Content(_messageService.GetMsgStateCount(businessId, showTagType, readType, msgType).ToString());
        }

        public ActionResult SetTagState()
        {
            string tokenkey = GetValue("tokenkey");
            if (!Common.Config.TokenKey.Equals(tokenkey))
            {
                return Content("");
            }
            int showTagType = ToolBox.ToSaveInt(GetValue("showTagType"));
            int readState = ToolBox.ToSaveInt(GetValue("readState"));
            int id = ToolBox.ToSaveInt(GetValue("id"));
            return Content(_messageService.SetTagState(id,showTagType,readState));
        }
    }
}
