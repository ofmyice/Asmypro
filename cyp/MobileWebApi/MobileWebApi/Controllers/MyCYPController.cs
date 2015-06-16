using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Common;
using MobileWebApi.Misc.Service;
using MobileWebApi.MVC;
using MobileWebApi.User.Service;
using System.Text;

namespace MobileWebApi.Controllers
{
    [MyAuth]
    public class MyCYPController :OnlineApiController
    {
        private IMyCYPService _myCypService;
        private IUserAccountService _userAccountService;
        public MyCYPController()
        {
            _myCypService = ServiceLocator.Current.GetInstance<IMyCYPService>();
            _userAccountService = ServiceLocator.Current.GetInstance<IUserAccountService>();
        }

        public ActionResult GetMyCypInfo()
        {
            int businessId = ToolBox.ToSaveInt(BusinessID);
            var result = _myCypService.GetMyCYPInfo(businessId);
            return Content(result);
        }
        /// <summary>
        /// 保存头像图片
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveHeadImg()
        {
            //string fileName = string.IsNullOrEmpty(GetValue("fileName")) ? "" : GetValue("fileName");
            //string fileData = string.IsNullOrEmpty(GetValue("fileData")) ? "" : GetValue("fileData");
            HttpPostedFileBase logo = Request.Files["logo"];
            return Content(_myCypService.SaveHeadImg(BusinessID,logo));
        }
    }
}
