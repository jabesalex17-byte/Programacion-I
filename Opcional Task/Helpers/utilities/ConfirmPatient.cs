using Opcional_Task.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.utilities
{
    internal class ConfirmPatient
    {
        public static bool Confirmpatient(string name, string lastname,string idcart,string sex,int age,string address,string telephone,string condition,string email, string question)
        {
            string message = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------\nConfirm Patient\n-----------------------------------------------\n");
                Console.WriteLine("============================================================");
                Console.WriteLine($"{"Name:",-12}{name}");
                Console.WriteLine($"{"Last Name:",-12}{lastname}");
                Console.WriteLine($"{"IdCard:",-12}{idcart}");
                Console.WriteLine($"{"Sex:",-12}{sex}");
                Console.WriteLine($"{"Age:",-12}{age}");
                Console.WriteLine($"{"Address:",-12}{address}");
                Console.WriteLine($"{"Telephone:",-12}{telephone}");
                Console.WriteLine($"{"Condition:",-12}{condition}");
                Console.WriteLine($"{"Email:",-12}{email}");
                Console.WriteLine("============================================================");
                Console.WriteLine();

                Console.WriteLine(message);
                Console.WriteLine(question);
                return YesOrNotAnswer.YesOrNotanswer() ? true : false;

            }
        }
    }
}
