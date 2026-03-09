using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Opcional_Task.Patients;
using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;

namespace Opcional_Task.Helpers.utilities
{
    internal class ModifyPatient
    {
        public static async Task Modifypatient(Patient patient, int answer)
        {
            string title = "------------------------------------------\nModifing Patient\n-----------------------------------------------";
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppPatient App = new AppPatient();
            PatientServices services = new PatientServices(App);

            switch (answer)
            {
                case 1:
                    patient.Name = Verifyfield.VerifyName.Verifyname(title);
                    break;

                case 2:
                    patient.LastName = Verifyfield.VerifyLastName.VerifylastName(title);
                    break;

                case 3:
                    patient.IdCart = Verifyfield.VerifyIdCart.VerifyidCart(title);
                    break;

                case 4:
                    patient.Sex = Verifyfield.VerifySex.Verifysex(title);
                    break;

                case 5:
                    patient.Age = Verifyfield.VerifyAges.VerifyAge(title);
                    break;

                case 6:
                    patient.Address = Verifyfield.VerifyAddress.Verifyaddress(title);
                    break;

                case 7:
                    patient.Telephone = Verifyfield.VerifyTelephone.Verifytelephone(title);
                    break;

                case 8:
                    patient.BornDay = Verifyfield.VerifyBornDay.VerifybornDay(title);
                    break;

                case 9:
                    patient.Condition = Verifyfield.VerifyCondition.Verifycondition(title);
                    break;

                case 10:
                    patient.Email = Verifyfield.VerifyEmail.Verifyemail(title);
                    break;

                case 11: // Modificar todo
                    patient.Name = Verifyfield.VerifyName.Verifyname(title);
                    patient.LastName = Verifyfield.VerifyLastName.VerifylastName(title);
                    patient.IdCart = Verifyfield.VerifyIdCart.VerifyidCart(title);
                    patient.Sex = Verifyfield.VerifySex.Verifysex(title);
                    patient.Age = Verifyfield.VerifyAges.VerifyAge(title);
                    patient.Address = Verifyfield.VerifyAddress.Verifyaddress(title);
                    patient.Telephone = Verifyfield.VerifyTelephone.Verifytelephone(title);
                    patient.BornDay = Verifyfield.VerifyBornDay.VerifybornDay(title);
                    patient.Condition = Verifyfield.VerifyCondition.Verifycondition(title);
                    patient.Email = Verifyfield.VerifyEmail.Verifyemail(title);
                    break;
            }

            await services.UpdatePatient(patient);
        }
    }
}
