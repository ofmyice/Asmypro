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
    public class CustomerService : ICustomerService
    {
        /// <summary>
        /// 获取提车点列表
        /// </summary>
        /// <returns></returns>
        public string GetCarPositionList()
        {
           CarPositionListInfo _carPositionListInfo=new CarPositionListInfo();
            _carPositionListInfo.SetState(ResState.Success);
            using (WcfMiscService.WcfMiscServiceClient c=new WcfMiscServiceClient())
            {
                var model=c.GetCarPositionList(Config.TokenKey);
                _carPositionListInfo.Data = model.DataList;
                _carPositionListInfo.TotalCount = model.TotalCount;
            }
            return JsonConvert.SerializeObject(_carPositionListInfo);
        }
        /// <summary>
        /// 添加建议与反馈
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="message"></param>
        /// <param name="messagetype"></param>
        /// <param name="ContactWay"></param>
        /// <returns></returns>
        public string SetSuggestion(string businessid, string message, string messagetype, string ContactWay)
        {
           BasisInfo _basisInfo=new BasisInfo();
            _basisInfo.SetState(ResState.Success);
            using (WcfMiscService.WcfMiscServiceClient c = new WcfMiscServiceClient())
            {
                var model = c.InsertMessage(Convert.ToInt32(businessid), message, Convert.ToInt32(messagetype),
                    ContactWay, Config.TokenKey);
            }
            return JsonConvert.SerializeObject(_basisInfo);
        }
    }
}
