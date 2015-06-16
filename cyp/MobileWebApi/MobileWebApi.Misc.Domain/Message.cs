using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.Misc.Domain
{
    public class Message : ListBasisInfo
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 消息类型，11：智能报价,12:交易成功,13:交易失败,14:系统公告
        /// </summary>
        public int MessageType { get; set; }

        /// <summary>
        /// 竞拍Id
        /// </summary>
        public int AucId { get; set; }
        /// <summary>
        /// 车辆Id
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// 大消息内容
        /// </summary>
        public string MsgContentBig { get; set; }
        /// <summary>
        /// 小消息内容
        /// </summary>
        public string MsgContentSmall { get; set; }
        /// <summary>
        /// 大消息查看标识  0  未查看   1 已查看 默认0
        /// </summary>
        public int ShowTagBig { get; set; }
        /// <summary>
        /// 小消息查看标识  0  未查看   1 已查看 默认0
        /// </summary>
        public int ShowTagSmall { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateDate { get; set; }
        /// <summary>
        /// 删除标识 0、正常 1、已删除
        /// </summary>
        public int DeleteTag { get; set; }
    }

    public class MessageData : ListBasisInfo
    {
    }
}
