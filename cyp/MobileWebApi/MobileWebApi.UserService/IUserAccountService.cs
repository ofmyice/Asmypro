using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.User.Service
{
    /// <summary>
    /// 用户账户资产信息相关
    /// </summary>
    public interface IUserAccountService
    {
        /// <summary>
        /// 资产中心首页信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        string GetCapitalIndex(string uid);

        /// <summary>
        /// 获取保证金信息
        /// </summary>
        string GetEarnestInfo(string uid);
        /// <summary>
        /// 获取保证金流水列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="begintTime"></param>
        /// <param name="tag"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        string GetEarnestLogList(string uid, DateTime begintTime, string tag, string pageIndex, string pageSize);
        /// <summary>
        /// 获取代金币信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        string GetVoucherInfo(string uid);
        /// <summary>
        /// 使用界面获取代金币信息
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="carid"></param>
        /// <returns></returns>
        string GetVoucherInfoInUse(string uid, string carid);
        /// <summary>
        /// 获取代金币列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="type"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        string GetVoucherLogList(string uid, string type, string pageIndex, string pageSize);
        /// <summary>
        /// 获取商信通账户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        string GetBusinessSxtInfo(string uid);
        /// <summary>
        /// 获取商信通还款列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        string GetSxtList(string uid, string pageIndex, string pageSize);
        string GetHeadImg(string uid);
    }
}
