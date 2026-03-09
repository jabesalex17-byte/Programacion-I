using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;
using Opcional_Task.Patients;
namespace Opcional_Task.Helpers.utilities
{
    internal class ViewListPatients
    {
        public async static Task ViewListpatients(bool exitFast = false)
        {
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppPatient app = new AppPatient();
            PatientServices services = new PatientServices(app);
            var listPatient = await services.GetListPatient();
            Console.Clear();
            Console.WriteLine("\n\n-----------------------------------------\r\nList Patient\r\n-----------------------------------------\n");
            foreach (Patient patient in listPatient)
            {
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
            }
            if (exitFast == false)
            {
                Console.WriteLine("Press enter to continue.................");
                Console.ReadKey();
            }
        }
    }
}
