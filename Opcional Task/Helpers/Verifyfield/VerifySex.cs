using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    internal class VerifySex
    {
        public static string Verifysex(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nWhat is your sex (Male or Female) (ej: Male)");
                string Sex = Console.ReadLine();

                if (utilities.SexAnswer.Male.Contains(Sex.ToLower().Trim()))
                {
                    return "Male";
                }
                else if (utilities.SexAnswer.Famele.Contains(Sex.ToLower().Trim()))
                {
                    return "Female";
                }
                else
                {
                    
                    continue;
                }
            }
        }
    }
}
