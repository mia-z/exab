using Blazored.LocalStorage;
using Common.Models;
using exab.web.Services.Contracts;
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

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {                
                Globals.User = await LocalStorage.GetItemAsync<User>("userdata");
                if (Globals.User == null)
                {
                    Globals.CurrentPage = "Create";
                    StateHasChanged();
                }
            }
            base.OnAfterRender(firstRender);
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
