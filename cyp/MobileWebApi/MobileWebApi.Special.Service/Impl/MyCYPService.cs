using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileWebApi.Common;
using MobileWebApi.Special.Domain;
using MobileWebApi.Special.Service.OrderService;
using Newtonsoft.Json;

namespace MobileWebApi.Special.Service.Impl
{
    public class MyCYPService:IMyCYPService
    {
        public string GetMyCYPInfo(string businessId)
        {
            ComprehensiveInfo info = new ComprehensiveInfo();
            using (WcfOrderServiceClient orderService = new WcfOrderServiceClient())
            {
                try
                {
                    info.Data = orderService.GetDealCarList(53733, 0, 1, "", -1, 10, 1, "DF@268vCYP");
                    info.SetState(ResState.Success);
                }
                catch (Exception)
                {
                    info.Data = null;
                    info.SetState(ResState.Fail);
                }
            }
            return JsonConvert.SerializeObject(info);
        }
    }
}
