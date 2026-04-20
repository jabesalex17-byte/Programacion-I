using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Utilities
{
    internal class ConfirmExit
    {
        public static bool Confirmexit()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║                Exit                  ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("\nAre you sure you want to exit?");
                return YesOrNotAnswer.YesOrNotanswer() ? true : false;
            }
        }
    }
}
