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
    internal class ModifyItem
    {
        public static async Task Modifyitem(Item item, int answer)
        {
            string title = "Modifing Item";
            if (!VerifyDb.Verifydb())
            {
                Console.WriteLine(VerifyDbStr.VerifydbStr());
                Console.WriteLine("press any key to continue....................");
                Console.ReadLine();
                return;
            }
            AppItem app = new AppItem();
            FamilyShopListServices services = new FamilyShopListServices(app);


            switch (answer)
            {
                case 1:
                    item.Name = Verifyfield.VerifyName.Verifyname(title);
                    break;

                case 2:
                    item.Amount = Verifyfield.VerifyAmount.Verifyamount(title);
                    break;

                case 3:
                    item.State = Verifyfield.VerifyState.Verifystate(title);
                    break;

                case 4:
                    item.Note = Verifyfield.VerifyNote.Verifynote(title);
                    break;

                case 5:
                    item.Name = Verifyfield.VerifyName.Verifyname(title);
                    item.Amount = Verifyfield.VerifyAmount.Verifyamount(title);
                    item.State = Verifyfield.VerifyState.Verifystate(title);
                    item.Note = Verifyfield.VerifyNote.Verifynote(title);
                    break;
            }

            await services.UpdateItem(item);
        }
    }
}
