using Blazored.LocalStorage;
using Common.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web.Pages
{
    public partial class Create : ComponentBase
    {
        [Inject]
        protected ILocalStorageService LocalStorage { get; set; }

        private User newUser { get; set; }


    }
}
