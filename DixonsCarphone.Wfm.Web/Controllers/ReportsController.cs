using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DixonsCarphone.Wfm.Web.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View("Wfm");
        }

        public ActionResult Footfall()
        {
            return View("Footfall");
        }

        public ActionResult KeyPerformace()
        {
            return View("Kpis");
        }

        public ActionResult Schedules()
        {
            return View("Schedules");
        }

        public ActionResult StorePandL()
        {
            return View("StorePandL");
        }

        public ActionResult Cgm()
        {
            return View("Cgm");
        }
    }
}