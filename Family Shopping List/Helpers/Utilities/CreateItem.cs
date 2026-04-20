using Family_Shopping_List.Items;
using Family_Shopping_List.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppItem = Family_Shopping_List.Data.DbContextFamilyShopList;
namespace Family_Shopping_List.Helpers.Utilities
{
    internal class CreateItem
    {
        public async static Task Createpatient(string name, int amount, string note, bool state)
        {
            var item = new Item()
            {
                Name = name,
                Amount = amount,
                Note = note,
                State = state

            };
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppItem app = new AppItem();
            FamilyShopListServices services = new FamilyShopListServices(app);
            await services.AddItem(item);

            Console.WriteLine("\nAdd Contant successfully");
            Console.WriteLine("Press enter to continue.............................");
            Console.ReadKey();
        }
    }
}
