using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;
using MobileWebApi.Misc.Service.WcfTaskService;
using Newtonsoft.Json;

namespace MobileWebApi.Misc.Service.Impl
{
    public class NewbieTaskService:INewbieTaskService
    {
        /// <summary>
        /// 获取任务总数信息
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="tasktype">0全部，1新手任务</param>
        /// <returns></returns>
        public string GetTaskCountInfo(string businessid,string tasktype)
        {
            TaskCountInfo _taskCountInfo=new TaskCountInfo();
            using (WcfTaskService.NewbieTaskClient c=new NewbieTaskClient())
            {
               string tempCount= c.GetUserInfoByTaskType(Convert.ToInt32(businessid), Convert.ToInt32(tasktype));
               // [0]已完成任务数 [1] 总任务数量 [2] 总代金币金额 [3]已经获取的代金币金额
                string[] arrStrings = tempCount.Split(',');
                _taskCountInfo.CompleteCount = Convert.ToInt32(arrStrings[0]);
                _taskCountInfo.CompleteReword = Convert.ToInt32(arrStrings[3]);
                _taskCountInfo.RewordCount = Convert.ToInt32(arrStrings[2]);
                _taskCountInfo.TaskCount = Convert.ToInt32(arrStrings[1]);
                _taskCountInfo.SetState(ResState.Success);
            }
            return JsonConvert.SerializeObject(_taskCountInfo);
        }
        /// <summary>
        /// 获取任务列表
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="tasktype"></param>
        /// <returns></returns>
        public string GetTaskListInfo(string businessid, string tasktype)
        {
            TaskListInfo _taskListInfo=new TaskListInfo();
            using (WcfTaskService.NewbieTaskClient c = new NewbieTaskClient())
            {
               var list = c.GetAllTaskList(Convert.ToInt32(tasktype), Convert.ToInt32(businessid));
                _taskListInfo.Data = list;
                _taskListInfo.TotalCount = list.Length;
                _taskListInfo.SetState(ResState.Success);
            }
            return JsonConvert.SerializeObject(_taskListInfo);
        }
    }
}
