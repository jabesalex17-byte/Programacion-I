using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Helpers.utilities;

namespace Task_4.Helpers.utilities
{
    public  class ConfirmContact
    {
        public static bool Confirmcontact(string name, string lastname, string address, string phone, string email, int age, bool isBestFriend, string question)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n-----------------------------------------\r\nConfirm Contact\r\n-----------------------------------------\n");
                Console.WriteLine(message);
                string isBestFriendStr = utilities.BestFriendstr.IsBestfriendStr(isBestFriend);
                Console.WriteLine($"First Name: {name} \nLast Name: {lastname} \nAddress: {address} \nPhone: {phone} \nEmail: {email} \nAge: {age} \nBest Friend: {isBestFriendStr}");
                Console.WriteLine(question);
                string answer = Console.ReadLine();

                if (utilities.UtilitiesList.affirmative.Contains(answer.ToLower().Trim()))
                {
                    return true;
                }
                else if (utilities.UtilitiesList.negative.Contains(answer.ToLower().Trim()))
                {
                    return false;
                }
                else
                {
                    message = "Yes or No (y or n, 1 or 2)\n";
                    continue;
                }

            }
        }
    }
}
