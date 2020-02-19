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

        [Parameter]
        public string CurrentPage { get; set; }

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        private string MenuButtonClass(string s) => s == Globals.CurrentPage ? "btn-success" : "btn-primary";
        private string ShouldHide(string loc) =>  loc == "Create" ? "" : "IsHidden";

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

            }
            base.OnAfterRender(firstRender);
        }

        private void SetPage(string page)
        {
            Globals.CurrentPage = page;
            var args = new NavigationEventArgs { Page = page };
            Nav.OnNavigate(this, args);
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }
    }
}
