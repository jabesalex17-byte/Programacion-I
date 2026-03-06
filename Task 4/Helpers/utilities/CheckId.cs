using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;
using Task_4.Domain;

namespace Task_4.Helpers.utilities
{
    public class CheckId
    {
        public static string Checkid()
        {
            string message = "";
            string answer = Console.ReadLine();

            if (answer.ToLower().Trim() == "exit")
            {
                return "exit";
            }
            if (answer.Trim() == "")
            {
                return "Please enter an ID";
            }
            if (!int.TryParse(answer, out int id))
            {
                return "Please enter a valid ID";
            }
            else if (!AddContact.ListContact.Any(c => c.id == id))
            {
                return "That ID does not exist";
            }
            else
            {
                return id.ToString();
            }
        }
    }
}
