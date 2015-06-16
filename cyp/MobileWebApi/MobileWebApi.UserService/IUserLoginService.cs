using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.User.Domain;

namespace MobileWebApi.User.Service
{
    public interface IUserLoginService
    {
        
        /// <summary>
        /// 判断用户是否在线
        /// </summary>
        /// <param name="OnlineID"></param>
        /// <returns></returns>
        bool CheckIsOnline(string OnlineID);
        /// <summary>
        /// 获取注册地筛选条件
        /// </summary>
        /// <returns></returns>
        string GetConfigInfo();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        string Login(string username, string password, string imei, string clienttype, string forceLogin,
            string provinceName, string cityName, string areaName, string streetName,string version);
    }
}
