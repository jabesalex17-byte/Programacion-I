using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.Verifyfield
{
    public class VerifyCondition
    {
        public static string Verifycondition(string title)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine(message);

                Console.WriteLine("\nDescribe your condition (ej: I've been feeling dizzy for the past few days and I can't walk.)");
                string condition = Console.ReadLine();

                if (condition.Trim().Length <= 10 || condition.Trim().Length >= 50)
                {
                    message = "For better description, write your condition with at least 10 characters and a maximum of 50";
                    continue;
                }
                else if (condition.Trim().Length == 0)
                {
                    message = "The condition cannot be empty";
                    continue;
                }

                return condition;
            }
        }
    }
}
