using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;
using MobileWebApi.Misc.Service.WcfMiscService;
using Newtonsoft.Json;

namespace MobileWebApi.Misc.Service.Impl
{
   public  class LogMessageService:ILogMessageService
    {
       /// <summary>
       /// 记录微信分享数据
       /// </summary>
       /// <param name="businessid"></param>
       /// <param name="tradeCode"></param>
       /// <param name="pagefrom"></param>
       /// <param name="shareto"></param>
       /// <returns></returns>
        public string LogShare(string businessid, string tradeCode, string pagefrom, string shareto)
        {
           LogShareInfo logShareInfo=new LogShareInfo();
           using (WcfMiscService.WcfMiscServiceClient c = new WcfMiscServiceClient())
           {
               WcfMiscService.ShareModel shareModel = c.LogShare(businessid, tradeCode, pagefrom, shareto,Config.TokenKey);
               if (shareModel.IsSuccess)
               {
                   logShareInfo.SetState(ResState.Success);
               }
           }
           return JsonConvert.SerializeObject(logShareInfo);
        }
    }
}
