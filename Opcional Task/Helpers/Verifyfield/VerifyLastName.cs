using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyLastName
    {
        public static string VerifylastName(string title)
        {
            string menssage = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(menssage);

                Console.WriteLine("\nEnter the person's last name (ej: Martinez)");
                string lastname = Console.ReadLine()!;
                if (lastname.Any(c => !char.IsLetter(c) && c != ' '))
                {
                    menssage = "\nThe last name can only contain letters ";
                    continue;
                }
                else if (lastname.Trim().Length == 1 || lastname.Trim().Length >= 16)
                {
                    menssage = "The last name must have between 2 and 15 characters";
                    continue;
                }
                else if (lastname.Trim().Length == 0)
                {
                    menssage = "The last name cannot be empty";
                    continue;
                }

                return lastname;
            }
        }
    }
}
