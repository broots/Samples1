using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DixonsCarphone.Wfm.Web.Models
{
    public class ControlModels
    {
        public List<string> Widgets { get; private set; }
        public List<string> Controls { get; private set; }

        public ControlModels()
        {
            Widgets = new List<string> { "_Events.cshtml", "_Footfall.cshtml", "_Orders.cshtml" };
            Controls = new List<string> { "_NewStaff.cshtml", "_ProductList.cshtml", "_UkKpis.cshtml" };
        }
    }
}