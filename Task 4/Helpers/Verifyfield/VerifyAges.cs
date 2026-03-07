using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.Verifyfield
{
    public class VerifyAges
    {
        public static int VerifyAge(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nEnter the person's age in numbers");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    message = "Please enter a valid age";
                    continue;
                }
                if (age < 5 || age > 85)
                {
                    message = "Only people between 5 and 85 years old";
                    continue;
                }

                return age;
            }
        }
    }
}
