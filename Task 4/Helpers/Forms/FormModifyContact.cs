using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Domain;
using Task_4.Helpers.utilities;

namespace Task_4.Helpers.Forms
{
    public class FormModifyContact
    {
        public static void Formodifycontact()
        {
            string message = "";
            bool exitF = true;
            int id;
            int information = 0;
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    ViewList.Viewlist(exitF);
                    Console.WriteLine("\n\n-----------------------------------------\r\nModify Contact\r\n-----------------------------------------\n");
                    Console.WriteLine(message);
                    Console.WriteLine("What is the ID of the person you want to modify?\n\nType 'exit' to quit");

                    string answer = utilities.CheckId.Checkid();
                    if (answer == "Please enter a valid ID" || answer == "That ID does not exist" || answer == "Please enter an ID")
                    {
                        message = answer;
                        continue;
                    }
                    if (answer.ToLower().Trim() == "exit")
                    {
                        return;
                    }
                    if ((answer.ToLower().Trim() != "please enter a valid id" && answer.ToLower().Trim() != "that id does not exist") || answer.ToLower().Trim() == "")
                    {
                        int.TryParse(answer, out id);
                        break;
                    }
                }

                message = "";
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n-----------------------------------------\r\nModify Contact\r\n-----------------------------------------\n");
                    Console.WriteLine("Type the number of what you want to modify\n\nType 'exit' to quit");
                    Console.WriteLine(message);
                    Console.WriteLine("1. First Name \n2. Last Name\n3. Address\n4. Phone\n5. Email\n6. Age\n7. Best Friend\n8. Modify All");

                    string answer = utilities.CheckInformation.Checkinformation();
                    if (answer.ToLower().Trim() == "exit")
                    {
                        break;
                    }
                    if (answer == "Please enter a valid number" || answer == "Please enter one of the options" || answer == "Please enter a number")
                    {
                        message = answer;
                        continue;
                    }
                    else
                    {
                        int.TryParse(answer, out information);
                        utilities.ModifyInformation.modifyInformation(id, information);
                        Console.WriteLine("\nModify Contant successfully");
                        Console.WriteLine("Press enter to continue.............................");
                        Console.ReadKey();
                    }
                }
            }

        }
    }
}
