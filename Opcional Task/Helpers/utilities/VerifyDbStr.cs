using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional_Task.Helpers.utilities
{
    internal class VerifyDbStr
    {
        public static string VerifydbStr()
        {
            return VerifyDb.Verifydb() ? "Database connected successfully" : "Database connection failed";
        }
    }
}
