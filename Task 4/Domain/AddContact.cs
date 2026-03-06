using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;

namespace Task_4.Domain
{
    public class AddContact
    {
        public static List<contact> ListContact = new List<contact>();
        public static void Addcontact(contact contact)
        {
            ListContact.Add(contact);
        }

    }
}
