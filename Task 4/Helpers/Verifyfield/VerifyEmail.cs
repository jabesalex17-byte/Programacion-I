using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.Verifyfield
{
    public  class VerifyEmail
    {
        public static string Verifyemail()
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the person's email");
                string email = Console.ReadLine();

                try
                {
                    MailAddress addr = new MailAddress(email);
                    return email;
                }
                catch
                {
                    message = "Invalid email";
                    continue;
                }
            }
        }
    }
}
