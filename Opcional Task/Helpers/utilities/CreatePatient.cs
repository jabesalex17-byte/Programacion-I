using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opcional_Task.Helpers.Forms;
using Opcional_Task.Patients;
using Opcional_Task.Services;
using AppPatient = Opcional_Task.Data.DbContextPatients;
namespace Opcional_Task.Helpers.utilities
{
    internal class CreatePatient
    {
        public async static Task Createpatient(string name, string lastname, string idcart, string sex, int age, string address, string telephone, DateTime bornday, string condition, string email)
        {
            var patient = new Patient()
            {
                Name = name,
                LastName = lastname,
                IdCart = idcart,
                Sex = sex,
                Age = age,
                Address = address,
                Telephone = telephone,
                BornDay = bornday,
                Condition = condition,
                Email = email
            };
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppPatient app = new AppPatient();
            PatientServices services = new PatientServices(app);
            await services.AddPatient(patient);

            Console.WriteLine("\nAdd Contant successfully");
            Console.WriteLine("Press enter to continue.............................");
            Console.ReadKey();
        }
    }
}
