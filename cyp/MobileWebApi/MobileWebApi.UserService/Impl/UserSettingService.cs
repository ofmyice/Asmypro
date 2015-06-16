using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.User.Domain;
using MobileWebApi.User.Service.UserWcfService;
using Newtonsoft.Json;

namespace MobileWebApi.User.Service.Impl
{
    public class UserSettingService : IUserSettingService
    {
        /// <summary>
        /// 获取用户短信息设置信息
        /// </summary>
        /// <param name="businessid"></param>
        /// <returns></returns>
        public string GetSmsSettingInfo(string businessid)
        {
            SmsSettingInfo _settingInfo=new SmsSettingInfo();
            _settingInfo.SetState(ResState.Success);
            using (UserSerWCFClient c=new UserSerWCFClient())
            {
                _settingInfo.Data=c.GetSmsSettingInfo(Convert.ToInt32(businessid), Config.TokenKey);
            }
            return JsonConvert.SerializeObject(_settingInfo);
        }

        /// <summary>
        /// 保存短信设置
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="cjdx"></param>
        /// <param name="tzdx"></param>
        /// <param name="sbdx"></param>
        /// <param name="spdx"></param>
        /// <returns></returns>
        public string SaveSmsSetting(string uid, string cjdx, string tzdx, string sbdx, string spdx)
        {
            BasisInfo basis=new BasisInfo();
            
            using (UserSerWCFClient c = new UserSerWCFClient())
            {
               bool b= c.SaveSmsSetting(Convert.ToInt32(uid), Convert.ToInt32(cjdx), Convert.ToInt32(tzdx),
                    Convert.ToInt32(sbdx), Convert.ToInt32(spdx), Config.TokenKey);
                if (b)
                {
                    basis.SetState(ResState.Success);
                }
            }
            return JsonConvert.SerializeObject(basis);
        }
    }
}
