using System.Web;
using MobileWebApi.Misc.Service.FileService;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Service.FileService;
using MobileWebApi.Misc.Service.WcfMiscService;
using MobileWebApi.Misc.Service.WcfTaskService;
using Newtonsoft.Json;
using MobileWebApi.Misc.Domain;
namespace MobileWebApi.Misc.Service.Impl
{
    public class MyCYPService : IMyCYPService
    {
        private readonly CYPLog.TextLogger _Log = CYPLog.TextLogManager.Create(typeof(MyCYPService));
        public string GetMyCYPInfo(int businessId)
        {
            MyCYPInfo info = new MyCYPInfo();
            using (WcfMiscService.WcfMiscServiceClient miscService =new WcfMiscServiceClient())
            {
                info.Data = miscService.GetMyCYPInfo(businessId, Config.TokenKey);
            }
            using (WcfTaskService.NewbieTaskClient c = new NewbieTaskClient())
            {
                string strTask = c.GetUserInfoByTaskType(businessId, 1);
                if (!string.IsNullOrEmpty(strTask))
                {
                    // [0]已完成任务数 [1] 总任务数量 [2] 总代金币金额 [3]已经获取的代金币金额
                    string[] arrTasks = strTask.Split(',');
                    info.UnCompleteTask = int.Parse(arrTasks[1]) - int.Parse(arrTasks[0]);
                }
            }
            info.SetState(ResState.Success);
            return JsonConvert.SerializeObject(info);
        }

        public string SaveHeadImg(string businessId,HttpPostedFileBase logo)
        {
            BasisInfo info = new BasisInfo();
            if (logo == null)
            {
                info.SetState(ResState.Fail);
                return JsonConvert.SerializeObject(info);
            }
            string houzhui = logo.FileName.Substring(logo.FileName.LastIndexOf(".") + 1).ToUpper();
            if (houzhui == "JPG" || houzhui == "GIF" || houzhui == "PNG" || houzhui == "JPEG")
            {
                string fileName = businessId + "_" + DateTime.Now.ToString("yyMMddHHmmss") + logo.FileName.Substring(logo.FileName.LastIndexOf("."));
                using (FileServiceClient fileService = new FileServiceClient())
                {
                    string path = DateTime.Now.ToString("yyMM/dd");
                    fileService.UploadFile(fileName, "s/" + path, logo.InputStream);
                    using (WcfMiscService.WcfMiscServiceClient miscService = new WcfMiscServiceClient())
                    {
                        try
                        {
                            _Log.Info("s/" + path);
                            _Log.Info(fileName);
                            _Log.Info(path + "/" + fileName);
                            miscService.UpdateHeadImg(path+"/" + fileName, ToolBox.ToSaveInt(businessId));
                        }
                        catch (Exception ex)
                        {
                            _Log.Info(ex.Message);
                        }
                    }
                    info.SetState(ResState.Success);
                }
            }
            return JsonConvert.SerializeObject(info);
        }
    }
}
