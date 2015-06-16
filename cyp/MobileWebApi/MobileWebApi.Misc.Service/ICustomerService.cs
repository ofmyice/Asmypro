using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Misc.Service
{
    /// <summary>
    /// 客服中心
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// 获取提车点列表
        /// </summary>
        /// <returns></returns>
        string GetCarPositionList();

        /// <summary>
        /// 添加建议与反馈
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="message"></param>
        /// <param name="messagetype"></param>
        /// <param name="ContactWay"></param>
        /// <returns></returns>
        string SetSuggestion(string businessid, string message, string messagetype, string ContactWay);
    }
}
