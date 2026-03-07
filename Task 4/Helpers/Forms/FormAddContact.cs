using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Helpers.Verifyfield;
using Task_4.Helpers.utilities;
using Task_4.Domain;
using Task_4.Contact;

namespace Task_4.Helpers.Forms
{
    public class FormAddContact
    {
        static int idCount = 1;
        static string title = "-----------------------------------------\nAdding Contact\n-----------------------------------------";
        public static void FormulContact()
        {
            Console.Clear();
            string name = VerifyName.Verifyname(title);
            string lastname = VerifyLastName.VerifylastName(title);
            string address = VerifyAddress.Verifyaddress(title);
            string phone = VerifyTelephone.Verifytelephone(title);
            string email = VerifyEmail.Verifyemail(title);
            int age = VerifyAges.VerifyAge(title);
            bool isBestFriend = VerifyBestFriend.VerifyBerstfriend(title);
            string question = "\nAre you sure you want to add this contact?\n";

            bool confirm = utilities.ConfirmContact.Confirmcontact(name, lastname, address, phone, email, age, isBestFriend, question);

            if (confirm)
            {
                Console.WriteLine("\nAdd Contant successfully");
                Console.WriteLine("Press enter to continue.............................");
                Console.ReadKey();
                var c = new contact
                {
                    Name = name,
                    LastName = lastname,
                    addresses = address,
                    phone = phone,
                    email = email,
                    Age = age,
                    BestFriend = isBestFriend,
                    id = idCount++
                };
                AddContact.Addcontact(c);
            }
        }
    }
}
