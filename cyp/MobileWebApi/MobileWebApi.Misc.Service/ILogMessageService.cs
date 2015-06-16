using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Misc.Service
{
    /// <summary>
    /// 记录信息类
    /// </summary>
    public interface ILogMessageService
    {
        /// <summary>
        /// 记录微信分享
        /// </summary>
        /// <param name="businessid"></param>
        /// <param name="tradeCode"></param>
        /// <param name="pagefrom"></param>
        /// <param name="shareto"></param>
        /// <returns></returns>
        string LogShare(string businessid, string tradeCode, string pagefrom, string shareto);
    }
}
