using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyName
    {
        public static string Verifyname(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);
                Console.WriteLine("\nEnter the person's name (ej: Jabes)");
                string name = Console.ReadLine()!;
                if (name.Any(c => !char.IsLetter(c) && c != ' '))
                {
                    message = "\nThe name can only contain letters";
                    continue;
                }
                else if (name.Trim().Length == 1 || name.Trim().Length >= 16)
                {
                    message = "The name must have between 2 and 15 characters";
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
