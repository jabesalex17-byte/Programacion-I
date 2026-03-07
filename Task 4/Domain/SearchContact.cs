using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Helpers.utilities;
using Task_4.Contact;

namespace Task_4.Domain
{
    public class SearchContact
    {
        public static void Search(int id)
        {
            contact c = AddContact.ListContact.FirstOrDefault(c => c.id == id)!;

            Console.Clear();
            Console.WriteLine("\n\n-----------------------------------------\r\nSearch Contact\r\n-----------------------------------------\n");
            string header = $"{"Id",-4} | {"First Name",-12} | {"Last Name",-12} | {"Address",-50} | {"Phone",-12} | {"Email",-35} | {"Age",-4} | {"Best Friend",-12}";

            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));

            Console.WriteLine($"{c.id,-4} | {c.Name,-12} | {c.LastName,-12} | {c.addresses,-50} | {c.phone,-12} | {c.email,-35} | {c.Age,-4} | {BestFriendstr.IsBestfriendStr(c.BestFriend),-12}");
            Console.WriteLine("\nSearch successfully\n");
            Console.Write("Press enter to continue..................");
            Console.ReadKey();
        }

    }
}
