using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DixonsCarphone.Wfm.Web.Controllers
{
    public class ProfilesController : Controller
    {
        // GET: StoreProfile
        public ActionResult Index()
        {
            return View("Store");
        }

        public ActionResult People()
        {
            return View("People");
        }
    }
}