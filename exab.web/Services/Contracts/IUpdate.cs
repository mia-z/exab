using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Services.Contracts
{
    public interface IUpdate
    {
        event EventHandler UpdatePage;
        public void StartTicker();
        public void StopTicker();
    }
}
