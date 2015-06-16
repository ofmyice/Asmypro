using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using MobileWebApi.Auctions.Data;
using MobileWebApi.Auctions.Domain.IRepositories;
using MobileWebApi.Auctions.Service;
using MobileWebApi.Auctions.Service.Impl;
using MobileWebApi.Misc.Domain.IRepositories;
using MobileWebApi.Misc.Service;
using MobileWebApi.Misc.Service.Impl;
using MobileWebApi.Order.Service;
using MobileWebApi.Order.Service.Impl;
using MobileWebApi.User.Data;
using MobileWebApi.User.Domain.IRepositories;
using MobileWebApi.User.Service;
using MobileWebApi.User.Service.Impl;
using MobileWebApi.Misc.Data;
namespace MobileWebApi
{
    public class ServiceLocatorInitializer
    {
        public static void Init()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IReadOnlyAuctionRepository, ReadOnlyAuctionRepository>();
            container.RegisterType<IAuctionService, AuctionService>();
            container.RegisterType<IUserAccountService, UserAccountService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IUserLoginService, UserLoginService>();
            container.RegisterType<ILogMessageService, LogMessageService>();
            container.RegisterType<IMyCYPService, MyCYPService>();
            container.RegisterType<ICompleteOrderService, CompleteOrderService>();
            container.RegisterType<IPushMessageService, PushMessageService>();
            container.RegisterType<INewbieTaskService, NewbieTaskService>();
            container.RegisterType<IUserSettingService, UserSettingService>();
            container.RegisterType<IReadOnlyUserRepository, ReadOnlyUserRepository>();
            container.RegisterType<IMessageService, MessageService>();
            container.RegisterType<IReadOnlyMessageRepository, ReadOnlyMessageRepository>();
            var locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}