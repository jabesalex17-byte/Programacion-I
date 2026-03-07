using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.Verifyfield
{
    public class VerifyTelephone
    {
        public static string Verifytelephone(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the person's phone number\n\n+18092342220 or 8098129834");
                string phone = Console.ReadLine();

                int Caracter = phone.Count(x => x == '+');
                if (Caracter > 1)
                {
                    message = "The number can only contain one +";
                    continue;
                }
                if (phone.Any(c => !char.IsDigit(c) && c != '+'))
                {
                    message = "Invalid character (the only allowed character is + to indicate the country code)";
                    continue;
                }
                else if (phone.Trim().Length <= 7 || phone.Trim().Length >= 20)
                {
                    message = "Invalid number";
                    continue;
                }

                return phone;
            }
        }
    }
}
