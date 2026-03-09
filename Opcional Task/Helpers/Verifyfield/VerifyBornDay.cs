using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyBornDay()
    {
        public static DateTime VerifybornDay(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);
                Console.WriteLine("What is your date of birth  dd/mm/yyyy (ej: 12/10/2002) ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime BornDay) || BornDay > DateTime.Now)
                {
                    message = "Enter a valid date";
                    continue;
                }

                return BornDay;
            }
        }
    }
}
