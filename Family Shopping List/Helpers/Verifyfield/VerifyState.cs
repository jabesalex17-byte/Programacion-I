using Family_Shopping_List.Helpers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Verifyfield
{
    public class VerifyState
    {
        public static bool Verifystate(string title)
        {
            string message = "";
            int width = 38;
            while (true)
            {
                Console.Clear();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔" + new string('═', width) + "╗");
                Console.WriteLine("║" + title.PadLeft((width + title.Length) / 2).PadRight(width) + "║");
                Console.WriteLine("╚" + new string('═', width) + "╝");
                Console.ResetColor();
                Console.WriteLine(message);
                Console.WriteLine(message);
                Console.WriteLine("\nDid you purchase this item?");
                return YesOrNotAnswer.YesOrNotanswer() ? true : false;

            }
        }
    }
}
