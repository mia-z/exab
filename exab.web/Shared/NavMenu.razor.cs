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
        protected IDynamicNavigator Nav { get; set; }

        [Parameter]
        public string CurrentPage { get; set; }

        private bool collapseNavMenu = true;

        private string[] NavItems { get; } = { "Create", "Character", "Train", "Explore", "Shop", "Rest", "Logs" };

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        private string MenuButtonClass(string s) => s == Globals.CurrentPage ? "btn-success" : "btn-primary";
        private string ShouldHide(string buttonName)
        {
            switch(buttonName)
            {
                case "Create":
                    if (Globals.CurrentPage == "Create")
                        return "";
                    else return "IsHidden";
                case "Train":
                case "Explore":
                case "Shop":
                case "Rest":
                case "Character":
                case "Logs":
                    if (Globals.CurrentPage != "Create")
                        return "";
                    else return "IsHidden";
                default:
                    return null;
            }
        }

        private void SetPage(string page)
        {
            Globals.CurrentPage = page;
            var args = new NavigationEventArgs { Page = page };
            Nav.OnNavigate(this, args);
        }
    }
}
