using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Verifyfield
{
    public class VerifyName
    {
        public static string Verifyname(string title)
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
                Console.WriteLine("\nEnter the item's name (ej: Milk)");
                string name = Console.ReadLine()!;
                if (name.Any(c => !char.IsLetter(c) && c != ' '))
                {
                    message = "\nThe name can only contain letters";
                    continue;
                }
                else if (name.Trim().Length == 1 || name.Trim().Length >= 21)
                {
                    message = "The name must have between 2 and 20 characters";
                    continue;
                }
                else if (name.Trim().Length == 0)
                {
                    message = "Your name must contain at least 2 characters";
                    continue;
                }

                return name;
            }
        }
    }
}
