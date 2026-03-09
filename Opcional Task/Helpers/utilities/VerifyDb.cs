using Opcional_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opcional_Task.Data;
namespace Opcional_Task.Helpers.utilities
{
    internal class VerifyDb
    {
        public static bool Verifydb()
        {
            DbContextPatients App = new DbContextPatients();
            return App.Database.CanConnect();
        }
    }
}
