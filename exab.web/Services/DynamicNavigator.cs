using exab.web.Services.Contracts;
using exab.web.Services.EventArgs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Services
{
    public class DynamicNavigator : IDynamicNavigator
    {
        public event EventHandler<NavigationEventArgs> Navigate;

        public void OnNavigate(object sender, NavigationEventArgs e)
        {
            EventHandler<NavigationEventArgs> handler = Navigate;
            handler?.Invoke(this, e);
        }
    }
}
