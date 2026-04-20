using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Utilities
{
    internal class StateStr
    {
        public static string Statestr(bool state)
        {
            return state ? "Purchased" : "Pending";
        }
    }
}
