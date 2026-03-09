using Opcional_Task.Helpers.utilities;
using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;
namespace Opcional_Task.Helpers.Forms
{
    internal class FormModifyPatient
    {
        public static async Task FormmodifyPatient()
        {
            bool exitFast = true;
            string message = "";
            while (true)
            {
                Console.Clear();
                await ViewListPatients.ViewListpatients(exitFast);
                Console.WriteLine("\n\n-----------------------------------------\r\nModify Patient\r\n-----------------------------------------\n");
                Console.WriteLine("what is the id of the patient you want to modify \n\nexit to leave\n");
                Console.WriteLine(message);

                string answer = Console.ReadLine();

                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if (!int.TryParse(answer, out int idPatient))
                {
                    message = "enter a valid id";
                    continue;
                }

                if (!VerifyDb.Verifydb())
                {
                    Console.WriteLine(VerifyDbStr.VerifydbStr());
                    Console.WriteLine("press any key to continue....................");
                    Console.ReadLine();
                    return;
                }
                AppPatient App = new AppPatient();
                PatientServices services = new PatientServices(App);
                var patient = await services.FindPatient(idPatient);

                if(patient == null)
                {
                    message = "there is no patient with that id";
                    continue;
                }
                message = "";
                while (true)
                {

                    Console.Clear();
                    Console.WriteLine("\n\n-----------------------------------------\r\nModify Patient\r\n-----------------------------------------\n");
                    Console.WriteLine("What do you want to modify?\n1 - Name\n2 - Last Name\n3 - ID Card\n4 - Sex\n5 - Age\n6 - Address\n7 - Telephone\n8 - Date of Birth\n9 - Condition\n10 - Email\n11 - Modify everything\n\nexit to go back\n");

                    Console.WriteLine(message);
                    Console.WriteLine("\nSelect an option: ");
                    string answer2 = Console.ReadLine();

                    if (answer2.ToLower().Trim() == "exit")
                    {
                        break;
                    }

                    if (!int.TryParse(answer2, out int option))
                    {
                        message = "select a valid option";
                        continue;
                    }

                    await ModifyPatient.Modifypatient(patient, option);
                    Console.WriteLine("\nModify Patient successfully");
                    Console.WriteLine("Press enter to continue.............................");
                    Console.ReadKey();
                }
            }
         
        }
    }
}
