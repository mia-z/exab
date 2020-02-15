using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Pages.Components.UI
{
    public partial class Player : ComponentBase
    {
        [Parameter]
        public int Number { get; set; }
    }
}
