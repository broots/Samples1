using DixonsCarphone.Wfm.Web.ViewModels.Models;
using DixonsCarphone.Wfm.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DixonsCarphone.Wfm.Web.Areas.Admin.Controllers
{
    public class UIController : Controller
    {
        private IEnumerable<WidgetsAndControls> ls;
        private string basePartialPath = "~/Views/Partials";
        private string serObjPath = string.Empty;  //@"C:\Dev\Serialized\HomeWidgetsAndControls.xml";

        public UIController()
        {
            ls = new List<WidgetsAndControls>
            {
                new WidgetsAndControls { Name = "Events", PathToPartial = basePartialPath + "/Widgets/_Events.cshtml" },
                new WidgetsAndControls { Name = "Footfall", PathToPartial = basePartialPath + "/Widgets/_Footfall.cshtml" },
                new WidgetsAndControls { Name = "Orders", PathToPartial = basePartialPath + "/Widgets/_Orders.cshtml" },
                new WidgetsAndControls { Name = "New Staff", PathToPartial = basePartialPath + "/_NewStaff.cshtml", OwnRow = true },
                new WidgetsAndControls { Name = "Product Lis", PathToPartial = basePartialPath + "/_ProductList.cshtml", OwnRow = true },
                new WidgetsAndControls { Name = "UK KPIs", PathToPartial = basePartialPath + "/_UkKpis.cshtml", OwnRow = true },

            };
        }
        public ActionResult Index()
        {
            serObjPath = HttpContext.Server.MapPath("~/Data/HomeWidgetsAndControls.xml");

            var model = Helpers.DeSerializeObject<List<WidgetsAndControls>>(serObjPath) ?? ls;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<WidgetsAndControls> model)
        {
            serObjPath = HttpContext.Server.MapPath("~/Data/HomeWidgetsAndControls.xml");

            model.ToList().SerializeObject(serObjPath);
            return View(model);
        }
    }
}