using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Auctions.Service;

namespace MobileWebApi.Controllers
{
    public class TradingCenterController : OnlineApiController
    {
        private readonly IAuctionService _auctionService;
        public TradingCenterController()
        {
            _auctionService = ServiceLocator.Current.GetInstance<IAuctionService>();
        }

        public ActionResult GetUnConfirmCars()
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
