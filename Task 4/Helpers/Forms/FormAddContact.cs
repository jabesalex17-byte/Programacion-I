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
        public static void FormulContact()
        {
            Console.Clear();
            string name = VerifyName.Verifyname();
            string lastname = VerifyLastName.VerifylastName();
            string address = VerifyAddress.Verifyaddress();
            string phone = VerifyTelephone.Verifytelephone();
            string email = VerifyEmail.Verifyemail();
            int age = VerifyAges.VerifyAge();
            bool isBestFriend = VerifyBestFriend.VerifyBerstfriend();
            string question = "\nAre you sure you want to add this contact?\n";

            bool confirm = utilities.ConfirmContact.Confirmcontact(name, lastname, address, phone, email, age, isBestFriend, question);

            if (confirm)
            {
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
