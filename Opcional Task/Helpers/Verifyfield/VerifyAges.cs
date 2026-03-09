using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
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

                Console.WriteLine("\nEnter the person's age in numbers(ej: 13)");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    message = "enter a valid age";
                    continue;
                }
                if (age < 1 || age > 85)
                {
                    message = "only people between 1 and 85 years old";
                    continue;
                }

                return age;
            }
        }
    }
}
