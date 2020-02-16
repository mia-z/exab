using exab.web.Services.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Services.Contracts
{
    public interface IDynamicNavigator
    {
        event EventHandler<NavigationEventArgs> Navigate;
        void OnNavigate(object sender, NavigationEventArgs e);
    }
}
