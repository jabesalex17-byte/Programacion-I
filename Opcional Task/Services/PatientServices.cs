using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Opcional_Task.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPatient = Opcional_Task.Data.DbContextPatients;
namespace Opcional_Task.Services
{
    public  class PatientServices
    {

        protected readonly AppPatient App;

        public PatientServices(AppPatient App2)
        {
            App = App2;
        }



        public async Task<List<Patient>> GetListPatient()
        {
            return await App.Patients.AsNoTracking().ToListAsync();
        }

        public async Task AddPatient(Patient patient)
        {
            App.Patients.Add(patient);
            await App.SaveChangesAsync();
        }

        public async Task DeletePatient(Patient patient)
        {
            App.Patients.Remove(patient);
            await App.SaveChangesAsync();
        }
       
        public async Task UpdatePatient(Patient patient)
        {
            App.Patients.Update(patient);
            await App.SaveChangesAsync();
        }

        public async Task<Patient?> FindPatient(int id)
        {
            var patient = await App.Patients.FirstOrDefaultAsync(p=> p.Id == id);
            return patient;
        }

        public async Task<bool> ExistPatient(int id)
        {
            var patient = await App.Patients.FirstOrDefaultAsync(p => p.Id == id);
            if (patient == null)
            {
                return false;
            }
            else
            {
                return true;
            }
   
        }

        
    }
}
