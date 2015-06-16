using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Misc.Service
{
    /// <summary>
    /// 消息推送接口
    /// </summary>
    public interface IPushMessageService
    {
        /// <summary>
        /// Pad及时推送
        /// </summary>
        /// <param name="msg"></param>
        void PushForPad(string msg);
        /// <summary>
        /// Pad延时推送
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="pushDate"></param>
        void PushForPadLate(string msg, DateTime pushDate);
        /// <summary>
        /// 手机及时推送
        /// </summary>
        /// <param name="msg"></param>
        void PushForMobile(string msg);
        /// <summary>
        /// 手机延时推送
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="pushDate"></param>
        void PushForMobileLate(string msg, DateTime pushDate);

        void PushMessage(string uids, string messagetype, string info);

    }
}
