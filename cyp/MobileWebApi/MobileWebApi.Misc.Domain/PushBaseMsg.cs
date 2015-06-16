using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Misc.Domain
{
    public class PushBaseMsg
    {
        /// <summary>
        /// 商户ID集合
        /// </summary>
        public List<int> BusinessId { get; set; }
        /// <summary>
        /// 消息类型，11：智能报价,12:交易成功,13:交易失败,14:系统公告
        /// </summary>
        public int MessageType { get; set; }
        /// <summary>
        /// 消息体
        /// </summary>
        public object MsgContent { get; set; }
    }
}
