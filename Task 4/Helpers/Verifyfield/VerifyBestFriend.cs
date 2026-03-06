using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Helpers.utilities;
namespace Task_4.Helpers.Verifyfield;

internal class VerifyBestFriend
{
    public static bool VerifyBerstfriend()
    {
        string message = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine(message);

            Console.WriteLine("\nIs this person your Best Friend?");
            string answer = Console.ReadLine();

            if (UtilitiesList.affirmative.Contains(answer.ToLower().Trim()))
            {
                return true;
            }
            else if (UtilitiesList.negative.Contains(answer.ToLower().Trim()))
            {
                return false;
            }
            else
            {
                message = "Yes or No (y or n, 1 or 2)";
                continue;
            }
        }
    }
}
