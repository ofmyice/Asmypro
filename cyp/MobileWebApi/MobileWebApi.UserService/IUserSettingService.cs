using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.User.Service
{
    /// <summary>
    /// 用户设置接口
    /// </summary>
    public interface IUserSettingService
    {
        /// <summary>
        /// 获取用户短信设置信息
        /// </summary>
        /// <param name="businessid"></param>
        /// <returns></returns>
        string GetSmsSettingInfo(string businessid);
        /// <summary>
        /// 保存短信设置
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="cjdx"></param>
        /// <param name="tzdx"></param>
        /// <param name="sbdx"></param>
        /// <param name="spdx"></param>
        /// <returns></returns>
        string SaveSmsSetting(string uid,string cjdx,string tzdx,string sbdx,string spdx);
    }
}
