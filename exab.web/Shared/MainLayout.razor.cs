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

        public void Tick(object sender, EventArgs e)
        {
            
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
