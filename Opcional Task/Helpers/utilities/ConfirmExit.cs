using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.utilities
{
    internal class ConfirmExit
    {
        public static bool Confirmexit()
        {
            while (true)
            {
                Console.WriteLine("\nAre you sure you want to exit?");
                return YesOrNotAnswer.YesOrNotanswer() ? true : false;
            }
        }
    }
}
