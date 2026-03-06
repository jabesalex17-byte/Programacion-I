using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;
using Task_4.Domain;
using Task_4.Helpers.utilities;

namespace Task_4.Helpers.Forms
{
    public class FormDeleteContact
    {
        public static void DeleteContact()
        {
            string message = "";
            bool exitF = true;
            string question = "are you sure you want to delete this contact?";
            while (true)
            {
                Console.Clear();
                ViewList.Viewlist(exitF);
                Console.WriteLine(message);
                message = "";
                Console.WriteLine("what is the id of the person you want to delete\n\nexit to leave");

                string answer = CheckId.Checkid();
                if (answer == "enter a valid id" || answer == "that id does not exist" || answer == "enter an id")
                {
                    message = answer;

                    continue;
                }
                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if ((answer.ToLower().Trim() != "enter a valid id" && answer.ToLower().Trim() != "that id does not exist") || answer.ToLower().Trim() == "")
                {
                    int.TryParse(answer, out int id);
                    contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id);
                    bool delete = ConfirmContact.Confirmcontact(c.Name, c.LastName, c.addresses, c.phone, c.email, c.Age, c.BestFriend, question);
                    Domain.DeleteContact.DeleteInformation(c);
                }
            }
        }
    }
}
