using Family_Shopping_List.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Utilities
{
    internal class ConfirmItem
    {
        public static bool Confirmpatient(string name,int amount, bool state, string note ,string question)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║             Confirm Item             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("============================================================");
                Console.WriteLine($"{"Name:"}{name}");
                Console.WriteLine($"{"amount:"}{amount}");
                Console.WriteLine($"{"state:"}{StateStr.Statestr(state)}");
                Console.WriteLine($"{"note:"}{note}");
                Console.WriteLine("============================================================");
                Console.WriteLine();

                Console.WriteLine(message);
                Console.WriteLine(question);
                return YesOrNotAnswer.YesOrNotanswer() ? true : false;

            }
        }
    }
}
