using Blazored.LocalStorage;
using Common.Models;
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
    public partial class MainLayout : IDisposable
    {
        [Inject]
        protected IUpdate Updater { get; set; }

        [Inject]
        protected ILocalStorageService LocalStorage { get; set; }

        [Inject]
        protected IDynamicNavigator Nav { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Globals.User = await LocalStorage.GetItemAsync<User>("userdata");
                if (Globals.User == null)
                {
                    NavEvent(this, new NavigationEventArgs { Page = "Create" });
                } 
                else
                {
                    NavEvent(this, new NavigationEventArgs { Page = "Character" });
                }
            }
            await InvokeAsync(StateHasChanged);
            base.OnAfterRender(firstRender);
        }

        private void NavEvent(object sender, NavigationEventArgs e)
        {
            Globals.CurrentPage = e.Page;
            StateHasChanged();
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Debug.WriteLine("Disposing");
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            Debug.WriteLine("Disposed");
        }
    }
}
