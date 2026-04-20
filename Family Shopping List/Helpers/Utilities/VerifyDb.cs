using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppItem = Family_Shopping_List.Data.DbContextFamilyShopList;
namespace Family_Shopping_List.Helpers.Utilities
{
    internal class VerifyDb
    {
        public static bool Verifydb()
        {
            AppItem App = new AppItem();
            return App.Database.CanConnect();
        }
    }
}
