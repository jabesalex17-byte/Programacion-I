using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;
using Task_4.Domain;
namespace Task_4.Helpers.utilities
{
    public class SearchByPhone
    {
        public static void SearchbyPhone()
        {
            string message = "";
            bool exitF = true;
            while (true)
            {
                Console.Clear();
                ViewList.Viewlist(exitF);
                Console.WriteLine("\n\n-----------------------------------------\r\nSearch Contact\r\n-----------------------------------------\n");
                Console.WriteLine(message);
                Console.WriteLine("What is the phone number of the person you want to search for?\n\nType 'exit' to go back");
                string answer = Console.ReadLine();

                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if (answer.Any(c => !char.IsDigit(c) && c != ' ' && c != '+'))
                {
                    message = "Please enter a valid number";
                    continue;
                }
                if (!AddContact.ListContact.Any(p => p.phone == answer.Trim()))
                {
                    message = "That number does not exist";
                    continue;
                }
                contact c = AddContact.ListContact.FirstOrDefault(c => c.phone == answer.Trim())!;
                SearchContact.Search(c.id);
            }
        }
    }
}
