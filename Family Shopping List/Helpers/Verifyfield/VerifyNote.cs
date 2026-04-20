using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Verifyfield
{
    public class VerifyNote
    {
        public static string Verifynote(string title)
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
                Console.WriteLine("\nEnter a note just adiccional information for this item (opcional) (Ej: sugar free cookies");
                string note = Console.ReadLine();

                if (note.Trim().Length >= 100)
                {
                    message = "<100 caracteres ";
                    continue;
                }

                return note;
            }
        }
    }
}
