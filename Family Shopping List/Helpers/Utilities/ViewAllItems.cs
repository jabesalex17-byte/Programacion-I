using Family_Shopping_List.Items;
using Family_Shopping_List.Services;
using AppItem = Family_Shopping_List.Data.DbContextFamilyShopList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Utilities
{
    internal class ViewAllItems
    {
        public async static Task ViewAllitems(bool exitFast = false)
        {
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppItem app = new AppItem();
            FamilyShopListServices services = new FamilyShopListServices(app);
            var ShoppingList = await services.GetAllItems();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║              List Item               ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();
            foreach (Item item in ShoppingList)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine($"{"Id:"}{item.Id}");
                Console.WriteLine($"{"Name:"}{item.Name}");
                Console.WriteLine($"{"amount:"}{item.Amount}");
                Console.WriteLine($"{"state:"}{StateStr.Statestr(item.State)}");
                Console.WriteLine($"{"note:"}{item.Note}");
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
