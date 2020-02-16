using exab.web.Services.Contracts;
using exab.web.Services.EventArgs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Shared
{
    public partial class NavMenu : ComponentBase
    {
        [Inject]
        IDynamicNavigator Nav { get; set; }

        private bool collapseNavMenu = true;

        private string[] NavItems { get; } = { "Create", "Fight" };

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        private void SetPage(string page)
        {
            var args = new NavigationEventArgs { Page = page };
            Nav.OnNavigate(this, args);
        }
    }
}
