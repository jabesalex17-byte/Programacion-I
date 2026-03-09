using Opcional_Task.Helpers.utilities;
using Opcional_Task.Patients;
using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;
namespace Opcional_Task.Helpers.Forms
{
    internal class FormSearchContact
    {
        public static async Task FormsearchContact()
        {
            bool exitFast = true;
            string message = "";
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppPatient app = new AppPatient();
            PatientServices services = new PatientServices(app);
            while (true)
            {
                Console.Clear();
                await ViewListPatients.ViewListpatients(exitFast);
                Console.WriteLine("\n\n-----------------------------------------\r\nSearch Patient\r\n-----------------------------------------\n");
                Console.WriteLine(message);
                Console.WriteLine("\nwhat is the id of the patient you want to search \n\nexit to leave");
                string answer = Console.ReadLine();
                if (answer.ToLower().Trim() == "exit") return;
                if (!int.TryParse(answer, out int idPatient))
                {
                    message = "enter a valid id";
                    continue;
                }
                Patient patient = await services.FindPatient(idPatient);
                if (patient == null)
                {
                    message = "there is no patient with that id";
                    continue;
                }
                ViewPatient.Viewpatient(patient);
            }
        }
    }
}
