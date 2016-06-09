using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DixonsCarphone.Wfm.Web.ViewModels.Models
{
    [Serializable]
    public class WidgetsAndControls
    {
        public string Name { get; set; }
        public string PathToPartial { get; set; }
        public bool ShowOnUi { get; set; }

        public bool OwnRow { get; set; }
    }
}
