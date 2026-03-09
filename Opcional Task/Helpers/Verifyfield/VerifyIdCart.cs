using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyIdCart
    {
        public static string VerifyidCart(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nEnter your IdCart number without - (ej: 12312345671 )");
                string phone = Console.ReadLine();


                if (phone.Any(c => !char.IsDigit(c)))
                {
                    message = "invalid character";
                    continue;
                }
                else if (phone.Trim().Length != 11)
                {
                    message = "invalid ID number";
                    continue;
                }

                return phone;
            }
        }
    }
}
