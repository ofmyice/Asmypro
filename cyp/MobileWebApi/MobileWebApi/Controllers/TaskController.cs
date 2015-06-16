using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Misc.Service;
using MobileWebApi.Misc.Service.Impl;
using MobileWebApi.Misc.Service.WcfTaskService;
using MobileWebApi.MVC;

namespace MobileWebApi.Controllers
{
    /// <summary>
    /// 任务中心
    /// </summary>
    [MyAuth]
    public class TaskController : OnlineApiController
    {
        private readonly INewbieTaskService _newbieTaskService;

        public TaskController()
        {
            _newbieTaskService = ServiceLocator.Current.GetInstance<INewbieTaskService>();
        }
        /// <summary>
        /// 获取任务总数信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTaskCountInfo()
        {
            string tasktype = string.IsNullOrWhiteSpace(GetValue("tasktype")) ? "1" : GetValue("tasktype");
            return Content(_newbieTaskService.GetTaskCountInfo(BusinessID, tasktype));
        }
        /// <summary>
        /// 获取任务列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTaskListInfo()
        {
            string tasktype = string.IsNullOrWhiteSpace(GetValue("tasktype")) ? "1" : GetValue("tasktype");
            return Content(_newbieTaskService.GetTaskListInfo(BusinessID, tasktype));
        }
    }
}
