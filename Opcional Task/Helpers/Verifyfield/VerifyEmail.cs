using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyEmail
    {
        public static string Verifyemail(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the person's email(ej: example@example.com)");
                string email = Console.ReadLine();

                try
                {
                    MailAddress addr = new MailAddress(email);
                    return email;
                }
                catch
                {
                    message = "invalid email";
                    continue;
                }
            }
        }
    }
}
