using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;
using Task_4.Helpers.utilities;
using Task_4.Domain;

namespace Task_4.Domain
{
    public class DeleteContact
    {
        public static void DeleteInformation(contact c)
        {
            AddContact.ListContact.Remove(c);
        }
    }
}
