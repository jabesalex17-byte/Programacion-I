using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.Verifyfield
{
    public class VerifyName
    {
        public static string Verifyname()
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine("\nEnter the person's first name");
                string name = Console.ReadLine()!;
                if (name.Any(c => !char.IsLetter(c) && c != ' '))
                {
                    message = "\nThe first name can only contain letters";
                    continue;
                }
                else if (name.Trim().Length == 1 || name.Trim().Length >= 16)
                {
                    message = "The first name must be between 2 and 15 characters";
                    continue;
                }
                else if (name.Trim().Length == 0)
                {
                    message = "The first name must contain at least 2 characters";
                    continue;
                }

                return name;
            }
        }
    }
}
