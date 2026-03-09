using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyAddress
    {
        public static string Verifyaddress(string title)
        {
            string message = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);
                Console.WriteLine("\nEnter the address(Ej: Carretera Sanchez Casa 5 calle 2");
                string address = Console.ReadLine();

                if (address.Trim().Length <= 8 || address.Trim().Length >= 50)
                {
                    message = "Your address must contain at least 8 characters and a maximum of 50";
                    continue;
                }
                else if (address.Trim().Length == 0)
                {
                    message = "The address cannot be empty";
                    continue;
                }

                return address;
            }
        }
    }
}
