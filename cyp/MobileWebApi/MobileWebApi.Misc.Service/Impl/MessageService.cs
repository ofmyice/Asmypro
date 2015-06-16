using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;
using MobileWebApi.Misc.Domain.IRepositories;
using Newtonsoft.Json;

namespace MobileWebApi.Misc.Service.Impl
{
    public class MessageService:IMessageService
    {
        private readonly IReadOnlyMessageRepository _readOnlyMessageRepo;

        public MessageService(IReadOnlyMessageRepository readOnlyMessageRepository)
        {
            _readOnlyMessageRepo = readOnlyMessageRepository;
        }
        /// <summary>
        /// 获取消息列表
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns></returns>
        public string GetMessageList(int businessId, int pageIndex, int pageSize)
        {
            var result=_readOnlyMessageRepo.GetMessageList(businessId,pageIndex,pageSize);
            MessageData list = new MessageData();
            list.TotalCount = result.TotalCount;
            list.Data = result.Items;
            list.SetState(ResState.Success);
            return JsonConvert.SerializeObject(list);
        }

        /// <summary>
        /// 通过Id获取具体消息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetMessageById(int id)
        {
            var result=_readOnlyMessageRepo.GetMessageById(id);
            Message msg = new Message();
            msg.Data = result;
            msg.SetState(ResState.Success);
            return JsonConvert.SerializeObject(msg);
        }

        /// <summary>
        /// 获取公告
        /// </summary>
        /// <returns></returns>
        public string GetNoticeList(int pageIndex, int pageSize)
        {
            var result = _readOnlyMessageRepo.GetNoticeList(pageIndex, pageSize);
            MessageData list = new MessageData();
            list.TotalCount = result.TotalCount;
            list.Data = result.Items;
            list.SetState(ResState.Success);
            return JsonConvert.SerializeObject(list);
        }

        /// <summary>
        /// 获取未读消息数量
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="showTagType"></param>
        /// <param name="readType"></param>
        /// <param name="msgType"></param>
        /// <returns></returns>
        public int GetMsgStateCount(int businessId, int showTagType, int readType, int msgType)
        {
            return _readOnlyMessageRepo.GetMsgStateCount(businessId, showTagType, readType, msgType);
        }

        /// <summary>
        /// 更新消息读的状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="showTagType"></param>
        public string SetTagState(int id, int showTagType, int readState)
        {
            return _readOnlyMessageRepo.SetTagState(id,showTagType,readState)>0?"操作成功":"操作失败";
        }
    }
}
