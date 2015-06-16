using System;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Common;
using MobileWebApi.User.Data;
using MobileWebApi.User.Domain;
using MobileWebApi.User.Domain.IRepositories;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.LoginWcfService;
using Newtonsoft.Json;

namespace MobileWebApi.User.Service.Impl
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IReadOnlyUserRepository _readOnlyUserRepository;

        public UserLoginService()
        {
            _readOnlyUserRepository = ServiceLocator.Current.GetInstance<IReadOnlyUserRepository>();
        }
        public bool CheckIsOnline(string OnlineID)
        {
            using (var client = new LoginWcfService.LoginWcfServiceClient())
            {
                return client.IsOnline(OnlineID);//判断是否在线
            }
        }

        public string GetConfigInfo()
        {
            ConfigInfo configInfo = new ConfigInfo();
            configInfo.SetState(ResState.Success);
            configInfo.RegArea = "京,沪,浙,苏,鲁,皖,豫,冀,赣,闽,津,川,粤,其他";
            return JsonConvert.SerializeObject(configInfo);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="imei"></param>
        /// <param name="clienttype"></param>
        /// <param name="forceLogin"></param>
        /// <param name="provinceName"></param>
        /// <param name="cityName"></param>
        /// <param name="areaName"></param>
        /// <param name="streetName"></param>
        /// <returns></returns>
        public string Login(string username, string password, string imei, string clienttype, string forceLogin, string provinceName, string cityName, string areaName, string streetName,string version)
        {
            var loginResultInfo = new LoginResultInfo();
            loginResultInfo.SetState(ResState.Success);
            if (!Common.Utils.IsUserName(username))
            {
                loginResultInfo.Tip = "您的用户名或密码输入有误，请重新输入！";
                loginResultInfo.Status = 5;
                return JsonConvert.SerializeObject(loginResultInfo);
            }
            var clientEnumType = LoginWcfService.EnumClientType.Other;
            switch (clienttype)
            {
                case "0":clientEnumType = LoginWcfService.EnumClientType.Android;break;
                case "1": clientEnumType = LoginWcfService.EnumClientType.Ios; break;
                case "3": clientEnumType = LoginWcfService.EnumClientType.AndroidPad; break;
                case "4": clientEnumType = LoginWcfService.EnumClientType.IosPad; break;
            }
            #region====调用登录服务
            using (var c=new LoginWcfServiceClient())
            {
                var clientInfo = new LoginWcfService.ClientInfo();
                clientInfo.ClientType = clientEnumType;
                clientInfo.IMEI = imei;
                clientInfo.Ip = string.Empty;
                clientInfo.Platform = version;
                clientInfo.ProvinceName = provinceName;
                clientInfo.CityName = cityName;
                clientInfo.AreaName = areaName;
                clientInfo.StreetName = streetName;
                var result = c.LoginWithClientInfo(username, password, forceLogin == "1", string.Empty, clientInfo);
                if (result.Status != LoginStatus.Success)
                {
                     switch (result.Status)
                    {
                        case LoginStatus.HasLogin:{loginResultInfo.Status = 1;loginResultInfo.Tip = "用户已登录";};break;
                        case LoginStatus.IsLocked: { loginResultInfo.Status = 2; loginResultInfo.Tip = "用户被锁定!"; }; break;
                        case LoginStatus.NoUser: { loginResultInfo.Status = 5; loginResultInfo.Tip = "您的用户名或密码输入有误，请重新输入!"; }; break;
                        case LoginStatus.PasswordError: { loginResultInfo.Status = 6; loginResultInfo.Tip = "密码错误!"; }; break;
                        case LoginStatus.UnActive: { loginResultInfo.Status = 4; loginResultInfo.Tip = "用户未激活!"; }; break;
                    }
                }
                else
                {
                    UserDto userDto = result.User;
                    loginResultInfo.BusinessId = Common.DesEncodeHelper.DESEnCode(userDto.UserId.ToString(),DesEncodeHelper.Key);
                    loginResultInfo.BusID = userDto.UserId;
                    loginResultInfo.Orid = userDto.Orid;
                    loginResultInfo.UserName = userDto.UserName;
                    loginResultInfo.UserCompanyName = userDto.CompanyName;
                    loginResultInfo.Onlineid = result.SessionId;
                    loginResultInfo.VipLevel = userDto.BuyerLevel;
                    loginResultInfo.DemonstrateTag = userDto.DemonstrateTag ? 1 : 0;
                    loginResultInfo.AllOrid = Common.ToolBox.IntArr2Str(userDto.UserRight);
                    loginResultInfo.Status = 0;
                    loginResultInfo.Tip = "登录成功";
                    loginResultInfo.UserType = userDto.UserType;
                    loginResultInfo.UserRight =_readOnlyUserRepository.GetUserRights(userDto.UserId.ToString());
                }

            }
            #endregion
            return JsonConvert.SerializeObject(loginResultInfo);
        }
    }
}
