using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Domain;
namespace Task_4.Helpers.utilities
{
    public class SeachById
    {
        public static void SearchById()
        {

            bool exitF = true;
            string messsage = "";
            while (true)
            {
                Console.Clear();
                ViewList.Viewlist(exitF);
                Console.WriteLine("\n\n-----------------------------------------\r\nSearch  Contact\r\n-----------------------------------------\n");
                Console.WriteLine(messsage);
                messsage = "";
                Console.WriteLine("What is the ID of the person you want to view?\n\nType 'exit' to go back\n");
                string answer = Console.ReadLine();

                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if (!int.TryParse(answer, out int search))
                {
                    messsage = "Please enter a number";
                    continue;
                }
                if (!AddContact.ListContact.Any(p => p.id.ToString() == answer.Trim()))
                {
                    messsage = "No person exists with that ID";
                    continue;
                }
                else
                {
                    SearchContact.Search(search);
                    continue;
                }
            }

        }

    }
    
}
