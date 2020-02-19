using Blazored.LocalStorage;
using Common.Models;
using exab.web.Services.Contracts;
using exab.web.Services.EventArgs;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace exab.web.Pages
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject]
        protected IUpdate Updater { get; set; }

        [Inject]
        protected ILocalStorageService LocalStorage { get; set; }

        [Inject]
        protected IDynamicNavigator Nav { get; set; }

        [Parameter]
        public string Current { get; set; }

        public string Counter = "";

        protected override void OnInitialized()
        {
            base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Nav.Navigate += NavEvent;
            }
            base.OnAfterRender(firstRender);
        }

        private string GetName() => Globals.User == null ? "No name" : Globals.User.Name;
        

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Debug.WriteLine("Disposing");
                    Nav.Navigate -= NavEvent;
                }
                disposedValue = true;
            }
        }

        private void NavEvent(object sender, NavigationEventArgs e)
        {
            Current = e.Page;
            InvokeAsync(StateHasChanged);
        }    

        public void Dispose()
        {
            Dispose(true);
            Debug.WriteLine("Disposed");
        }
    }
}
