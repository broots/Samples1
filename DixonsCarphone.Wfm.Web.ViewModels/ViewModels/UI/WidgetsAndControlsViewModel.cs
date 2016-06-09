using DixonsCarphone.Wfm.Web.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DixonsCarphone.Wfm.Web.ViewModels.ViewModels.UI
{
    public class WidgetsAndControlsViewModel
    {
        public List<WidgetsAndControls> UiControls { get; private set; }

        public WidgetsAndControlsViewModel(List<WidgetsAndControls> uiControls)
        {
            UiControls = uiControls;
        }
    }
}
