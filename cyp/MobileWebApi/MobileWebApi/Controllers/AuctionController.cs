using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileWebApi.Auctions.Service;
using Microsoft.Practices.ServiceLocation;
using MobileWebApi.Common;
using MobileWebApi.Models;
using MobileWebApi.MVC;

namespace MobileWebApi.Controllers
{
    
    public class AuctionController :OnlineApiController
    {
        //
        // GET: /Auction/
        private readonly IAuctionService _auctionService;
        public AuctionController()
        {
            _auctionService = ServiceLocator.Current.GetInstance<IAuctionService>();
        }
        public ActionResult GetHotCars()
        {
            string tokenkey = GetValue("tokenkey");
            string top = GetValue("top");
            string aucType = GetValue("aucType");
            int auctionType = ToolBox.ToSaveInt(aucType);
            ModelView result = new ModelView();
            if (!Common.Config.TokenKey.Equals(tokenkey) || ToolBox.ToSaveInt(top)==0)
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            if (auctionType == 1 || auctionType == 2)
            {
                result = new ModelView().BindList(_auctionService.GetHotCars(ToolBox.ToSaveInt(top), auctionType),auctionType);
            }
            else
            {
                result = new ModelView().BindList(_auctionService.GetHotCars(ToolBox.ToSaveInt(top), 1), _auctionService.GetHotCars(ToolBox.ToSaveInt(top), 2));
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
