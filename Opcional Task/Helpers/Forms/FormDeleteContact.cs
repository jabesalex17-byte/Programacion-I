using Opcional_Task.Helpers.utilities;
using Opcional_Task.Patients;
using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;
namespace Opcional_Task.Helpers.Forms
{
    internal class FormDeleteContact
    {
        static string question = "are you sure you want to delete this contact (yes or no)";
        public static async Task FormdeleteContact()
        {
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppPatient app = new AppPatient();
            PatientServices servies = new PatientServices(app);
            bool exitFast = true;
            string message = "";
            while (true)
            {
                Console.Clear();
                await ViewListPatients.ViewListpatients(exitFast);
                Console.WriteLine("\n\n-----------------------------------------\r\nModify Patient\r\n-----------------------------------------\n");
                Console.WriteLine(message);
                Console.WriteLine("\nwhat is the id of the patient you want to delete \n\nexit to leave");

                string answer = Console.ReadLine()!;
                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if (!int.TryParse(answer, out int idPatient))
                {
                    message = "enter a valid id";
                    continue;
                }

                Patient patient = await servies.FindPatient(idPatient);

                if (patient == null)
                {
                    message = "there is no patient with this id";
                    continue;
                }
                if(ConfirmPatient.Confirmpatient(patient.Name,patient.LastName,patient.IdCart,patient.Sex, patient.Age, patient.Address, patient.Telephone, patient.Condition, patient.Email, question))
                {
                    await servies.DeletePatient(patient);
                    Console.WriteLine("\nModify Contant successfully");
                    Console.WriteLine("Press enter to continue.............................");
                    Console.ReadKey();
                }
                
            }
        }
    }
}
