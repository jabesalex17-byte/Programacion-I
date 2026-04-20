using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Verifyfield
{
    public class VerifyAmount
    {
        public static int Verifyamount(string title)
        {
            string message = "";
            int width = 38;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔" + new string('═', width) + "╗");
                Console.WriteLine("║" + title.PadLeft((width + title.Length) / 2).PadRight(width) + "║");
                Console.WriteLine("╚" + new string('═', width) + "╝");
                Console.ResetColor();
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the item amount (ej: 13)");
                if (!int.TryParse(Console.ReadLine(), out int amount))
                {
                    message = "enter a amount";
                    continue;
                }
                if (amount < 1 || amount > 10001)
                {
                    message = "<10000 plis";
                    continue;
                }

                return amount;
            }
        }
    }
}
