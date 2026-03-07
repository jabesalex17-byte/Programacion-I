using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Domain;
using Task_4.Helpers.utilities;
namespace Task_4.Helpers.Forms
{
    public class FormSearchContact
    {
        public static void SearchContact()
        {
            string message = "";
            bool exitF = true;
            while (true)
            {
                Console.Clear();
                ViewList.Viewlist(exitF);
                Console.WriteLine("\n\n-----------------------------------------\r\nSearch  Contact\r\n-----------------------------------------\n");
                Console.WriteLine("Do you want to search by ID or by the person's number?\n\nType 'exit' to quit");
                Console.WriteLine(message);
                message = "";
                string answer = Console.ReadLine();

                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }

                if (utilities.UtilitiesList.AnswerId.Contains(answer.ToLower().Trim()))
                {
                    utilities.SeachById.SearchById();
                    continue;
                }
                else if (utilities.UtilitiesList.AnswerNum.Contains(answer.ToLower().Trim()))
                {
                    utilities.SearchByPhone.SearchbyPhone();
                    continue;
                }
                else
                {
                    message = "Enter the field you want to search for";
                }
            }
        }
    }
}
