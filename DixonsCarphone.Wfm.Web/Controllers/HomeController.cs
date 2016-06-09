using DixonsCarphone.Wfm.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DixonsCarphone.Wfm.Web.ViewModels;
using DixonsCarphone.Wfm.Web.ViewModels.Models;

namespace DixonsCarphone.Wfm.Web.Controllers
{
    public class HomeController : Controller
    {
        private string serObjPath;
        private string basePartialPath = "~/Views/Partials";

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            serObjPath = HttpContext.Server.MapPath("~/Data/HomeWidgetsAndControls.xml");

            var model = Helpers.DeSerializeObject<List<WidgetsAndControls>>(serObjPath) ?? GetNewModel();

            return View("ModernBizTemplate", model.Where(x => x.ShowOnUi).ToList());
        }

        private List<WidgetsAndControls> GetNewModel()
        {
            var ls = new List<WidgetsAndControls>
            {
                new WidgetsAndControls { Name = "Events", PathToPartial = basePartialPath + "/Widgets/_Events.cshtml" },
                new WidgetsAndControls { Name = "Footfall", PathToPartial = basePartialPath + "/Widgets/_Footfall.cshtml" },
                new WidgetsAndControls { Name = "Orders", PathToPartial = basePartialPath + "/Widgets/_Orders.cshtml" },
                new WidgetsAndControls { Name = "New Staff", PathToPartial = basePartialPath + "/_NewStaff.cshtml", OwnRow = true },
                new WidgetsAndControls { Name = "Product Lis", PathToPartial = basePartialPath + "/_ProductList.cshtml", OwnRow = true },
                new WidgetsAndControls { Name = "UK KPIs", PathToPartial = basePartialPath + "/_UkKpis.cshtml", OwnRow = true },

            };

            return ls;
        }
    }
}
