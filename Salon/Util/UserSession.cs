using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Util
{
    public static class UserSession
    {
        public static Form1 LoginFormInstance { get; set; }
        public static UsersModel CurrentUser { get; set; }

        public static void Clear() { CurrentUser = null; }

    }
}
