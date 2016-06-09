using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DixonsCarphone.Wfm.Web.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            return View();
        }

        #region Json
        public JsonResult GetPieChartData()
        {

            var data = new[] { new { Name = "9am-11am", Value = 25000 },
                                new { Name = "11am-1pm", Value = 5418 },
                                new { Name = "1pm-3pm", Value = 8457 },
                                new { Name = "3pm-4pm", Value = 12457 },
                                new { Name = "4pm-5pme", Value = 874 },};

            return Json(data);
        }
        #endregion 

        #region Child-Only

        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Users()
        {
            return View();
        }
        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Orders()
        {

            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_SalesPie()
        {


            return View();
        }
        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Visitors()
        {


            return View();
        }
        #endregion
    }

}