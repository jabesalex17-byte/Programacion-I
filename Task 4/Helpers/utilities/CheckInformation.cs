using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Helpers.utilities
{
    public  class CheckInformation
    {
        public static string Checkinformation()
        {
            string message = "";
            string answer = Console.ReadLine();

            if (answer.ToLower().Trim() == "exit")
            {
                return "exit";
            }
            if (answer.ToLower().Trim() == "")
            {
                return "Please enter a number";
            }
            if (!int.TryParse(answer, out int information))
            {
                message = "Please enter a valid number";
                return message;
            }
            if (information < 1 || information > 8)
            {
                message = "Please enter one of the options";
                return message;
            }
            else
            {
                return information.ToString();
            }
        }
    }
}
