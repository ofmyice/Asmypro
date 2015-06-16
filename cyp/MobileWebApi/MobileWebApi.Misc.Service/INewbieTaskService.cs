using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Misc.Service
{
   public  interface INewbieTaskService
   {
       /// <summary>
       /// 获取任务总数信息
       /// </summary>
       /// <param name="businessid"></param>
       /// <returns></returns>
       string GetTaskCountInfo(string businessid,string tasktype);
       /// <summary>
       /// 获取任务服务列表
       /// </summary>
       /// <param name="businessid"></param>
       /// <param name="tasktype"></param>
       /// <returns></returns>
       string GetTaskListInfo(string businessid, string tasktype);
   }
}
