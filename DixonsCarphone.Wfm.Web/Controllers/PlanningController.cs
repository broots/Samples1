using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DixonsCarphone.Wfm.Web.Controllers
{
    public class PlanningController : Controller
    {
        // GET: PlanningAhead
        public ActionResult Index()
        {
            return View("CustomerTraffic");
        }

        public ActionResult Local()
        {
            return View("LocalLevelEvents");
        }
    }
}