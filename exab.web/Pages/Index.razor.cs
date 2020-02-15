using exab.web.Services;
using exab.web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Diagnostics;
using Microsoft.JSInterop;
using Blazored.LocalStorage;

namespace exab.web.Pages
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject]
        protected IUpdate Updater { get; set; }

        [Inject]
        protected ILocalStorageService LocalStorage { get; set; }

        public int Counter = 0;

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                
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
