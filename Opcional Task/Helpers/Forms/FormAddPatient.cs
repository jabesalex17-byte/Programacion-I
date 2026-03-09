using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Opcional_Task.Helpers.utilities;
using Opcional_Task.Helpers.Verifyfield;
using Opcional_Task.Patients;

namespace Opcional_Task.Helpers.Forms
{
        public class FormAddPatient
        {
            static int idCount = 1;
            static string question = "are you sure you want to add this patient (yes or no)";
            public static async Task formaddPatient()
            {
                Console.Clear();
                string title = "------------------------------------------\nAdding Patient\n-----------------------------------------------\n";
                string name = VerifyName.Verifyname(title);
                string lastname = VerifyLastName.VerifylastName(title);
                string address = VerifyAddress.Verifyaddress(title);
                string phone = VerifyTelephone.Verifytelephone(title);
                string email = VerifyEmail.Verifyemail(title);
                int age = VerifyAges.VerifyAge(title);
                DateTime BornDay = VerifyBornDay.VerifybornDay(title);
                string condition = VerifyCondition.Verifycondition(title);
                string IdCart = VerifyIdCart.VerifyidCart(title);
                string sex = VerifySex.Verifysex(title );


                if (ConfirmPatient.Confirmpatient(name, lastname, IdCart, sex, age, address, phone, condition, email, question))
                {
                    await CreatePatient.Createpatient(name, lastname, IdCart, sex, age, address, phone, BornDay, condition, email);
                }
            }
        }
}
