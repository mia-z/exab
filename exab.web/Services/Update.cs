using exab.web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;

namespace exab.web.Services
{
    public class Update : IUpdate
    {
        public event EventHandler UpdatePage;
        private Timer GameTick;

        public Update()
        {
            GameTick = new Timer(1000);
            GameTick.AutoReset = true;
            GameTick.Elapsed += OnTickHandler;
        }

        public void StartTicker()
        {
            GameTick.Enabled = true;
        }

        public void StopTicker()
        {
            GameTick.Stop();
        }

        private void OnTickHandler(object source, ElapsedEventArgs e)
        {
            EventHandler h = UpdatePage;
            h?.Invoke(source, e);
        }
    }
}
