using Opcional_Task.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.utilities
{
    internal class ViewPatient
    {
        public static void Viewpatient(Patient patient)
        {
            Console.Clear();
            Console.WriteLine("\n\n-----------------------------------------\r\nSearch Patient successfully\r\n-----------------------------------------\n");
            Console.WriteLine("============================================================");
            Console.WriteLine($"{"Id:",-12}{patient.Id}");
            Console.WriteLine($"{"Name:",-12}{patient.Name}");
            Console.WriteLine($"{"Last Name:",-12}{patient.LastName}");
            Console.WriteLine($"{"IdCard:",-12}{patient.IdCart}");
            Console.WriteLine($"{"Sex:",-12}{patient.Sex}");
            Console.WriteLine($"{"Age:",-12}{patient.Age}");
            Console.WriteLine($"{"Address:",-12}{patient.Address}");
            Console.WriteLine($"{"Telephone:",-12}{patient.Telephone}");
            Console.WriteLine($"{"BornDay:",-12}{patient.BornDay}");
            Console.WriteLine($"{"Condition:",-12}{patient.Condition}");
            Console.WriteLine($"{"Email:",-12}{patient.Email}");
            Console.WriteLine("============================================================");
            Console.WriteLine();

            Console.WriteLine("Press enter to continue.................");
            Console.ReadKey();
        }
    }
}
