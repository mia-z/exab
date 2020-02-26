using Blazored.LocalStorage;
using Common.Models;
using exab.web.Services.Contracts;
using exab.web.Services.EventArgs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Pages
{
    public partial class Create : ComponentBase
    {
        [Inject]
        protected ILocalStorageService LocalStorage { get; set; }

        [Inject]
        protected IDynamicNavigator Nav { get; set; }

        public string NameText { get; set; }

        private async void CreateCharacter()
        {
            if (!string.IsNullOrWhiteSpace(NameText))
            {
                Globals.CurrentPage = "Home";
                Globals.User = new User(NameText);
                await LocalStorage.SetItemAsync("userdata", Globals.User);
                Nav.OnNavigate(this, new NavigationEventArgs { Page = "Home" });
            }
            else
            {

            }
        }
    }
}
