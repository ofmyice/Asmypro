using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileWebApi.Controllers
{
    public class NologinController : Controller
    {
        //
        // GET: /Nologin/

        public ActionResult Index()
        {
            return Content("-10010");
        }

    }
}
