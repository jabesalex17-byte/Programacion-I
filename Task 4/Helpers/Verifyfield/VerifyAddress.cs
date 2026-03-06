using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.Verifyfield
{
    public  class VerifyAddress
    {
        public static string Verifyaddress()
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the address");
                string address = Console.ReadLine();

                if (address.Trim().Length <= 8 || address.Trim().Length >= 50)
                {
                    message = "Your address must be at least 8 characters and a maximum of 50";
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
