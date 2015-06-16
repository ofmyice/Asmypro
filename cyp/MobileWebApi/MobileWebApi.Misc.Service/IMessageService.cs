using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;

namespace MobileWebApi.Misc.Service
{
    public interface IMessageService
    {
        /// <summary>
        /// 获取消息列表
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns></returns>
        string GetMessageList(int businessId, int pageIndex, int pageSize);
        /// <summary>
        /// 通过Id获取具体消息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetMessageById(int id);
        /// <summary>
        /// 获取公告
        /// </summary>
        /// <returns></returns>
        string GetNoticeList(int pageIndex, int pageSize);
        /// <summary>
        /// 获取未读消息数量
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="showTagType"></param>
        /// <param name="readType"></param>
        /// <param name="msgType"></param>
        /// <returns></returns>
        int GetMsgStateCount(int businessId, int showTagType, int readType, int msgType);
        /// <summary>
        /// 更新消息读的状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="showTagType"></param>
        string SetTagState(int id, int showTagType, int readState);
    }
}
