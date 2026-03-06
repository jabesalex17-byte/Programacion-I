using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Contact;

namespace Task_4.Domain
{
    public class ModifyContact()
    {

        public static void modifyName(int id, string information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.Name = information;
        }
        public static void modifyLastname(int id, string information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.LastName = information;
        }
        public static void modifyAddress(int id, string information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.addresses = information;
        }
        public static void modifyTelephones(int id, string information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.phone= information;
        }
        public static void modifyEmails(int id, string information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.email = information;
        }
        public static void modifyAges(int id, int information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.Age = information;
        }
        public static void modifyBestfriend(int id, bool information)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;
            c.BestFriend = information;
        }

    }
}
