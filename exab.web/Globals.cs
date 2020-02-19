using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exab.web
{
    public static class Globals
    {
        public static int Counter { get; set; } = 0;
        public static bool HasCharacter { get;  private set; }
        public static string CurrentPage { get; set; }
        public static User User { get; set; }
    }
}
