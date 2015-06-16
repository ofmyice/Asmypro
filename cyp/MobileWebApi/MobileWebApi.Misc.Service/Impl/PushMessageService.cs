using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;
using MobileWebApi.Misc.Service.WcfPushService;
using Newtonsoft.Json;

namespace MobileWebApi.Misc.Service.Impl
{

    public class PushMessageService:IPushMessageService
    {
        public PushMessageService()
        {
            
        }
        public void PushForPad(string msg)
        {
            try
            {
                using (WcfPushService.PushSerClient c = new PushSerClient())
                {
                    c.PushForPad(Config.PadPushKey, msg);
                }
            }
            catch
            {

            }
            
        }

        public void PushForPadLate(string msg, DateTime pushDate)
        {
            try
            {
                using (WcfPushService.PushSerClient c = new PushSerClient())
                {
                    c.PushForPadLate(Config.PadPushKey, msg, pushDate);
                }
            }
            catch 
            {
            }
            
        }

        public void PushForMobile(string msg)
        {
            try
            {
                using (WcfPushService.PushSerClient c = new PushSerClient())
                {
                    c.PushForMobile(Config.MobilePushKey, msg);
                }
            }
            catch
            {
            }

        }

        public void PushForMobileLate(string msg, DateTime pushDate)
        {
            try
            {
                using (WcfPushService.PushSerClient c = new PushSerClient())
                {
                    c.PushForMobileLate(Config.MobilePushKey, msg, pushDate);
                }
            }
            catch 
            {
            }

        }

        /// <summary>
        /// 推送消息
        /// </summary>
        /// <param name="uids"></param>
        /// <param name="messagetype"></param>
        /// <param name="info"></param>
        public void PushMessage(string uids, string messagetype, string info)
        {
            PushBaseMsg _pushBaseMsg=new PushBaseMsg();
            _pushBaseMsg.MessageType = Convert.ToInt32(messagetype);
            _pushBaseMsg.BusinessId = (uids == "0"||string.IsNullOrWhiteSpace(uids)) ? new List<int>(){0} : Common.ToolBox.Str2List<int>(uids);
            _pushBaseMsg.MsgContent = new {Title = "CCCC", Content = "DDDD", Time = "1993-23-23"};
            PushForMobile(JsonConvert.SerializeObject(_pushBaseMsg));
        }
    }
}
