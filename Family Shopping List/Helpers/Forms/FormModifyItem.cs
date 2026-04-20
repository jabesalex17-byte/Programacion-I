using Family_Shopping_List.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppItem = Family_Shopping_List.Data.DbContextFamilyShopList;
namespace Family_Shopping_List.Helpers.Forms
{
    internal class FormModifyItem
    {
        public static async Task Formmodifyitem()
        {
            bool exitFast = true;
            string message = "";
            while (true)
            {
                Console.Clear();
                await Helpers.Utilities.ViewAllItems.ViewAllitems(exitFast);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║             Modify Item              ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("what is the id of the item you want to modify \n\nexit to leave\n");
                Console.WriteLine(message);

                string answer = Console.ReadLine();

                if (answer.ToLower().Trim() == "exit")
                {
                    return;
                }
                if (!int.TryParse(answer, out int idItem))
                {
                    message = "enter a valid id";
                    continue;
                }

                if (!Utilities.VerifyDb.Verifydb())
                {
                    Console.WriteLine(Utilities.VerifyDbStr.VerifydbStr());
                    Console.WriteLine("press any key to continue....................");
                    Console.ReadLine();
                    return;
                }
                AppItem app = new AppItem();
                FamilyShopListServices services = new FamilyShopListServices(app);
                var item = await services.FindItem(idItem);

                if (item == null)
                {
                    message = "there is no item with that id";
                    continue;
                }
                message = "";
                while (true)
                {

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║             Modify Item              ║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  [1] ➜ Name");
                    Console.WriteLine("  [2] ➜ Amount");
                    Console.WriteLine("  [3] ➜ State");
                    Console.WriteLine("  [4] ➜ Note");
                    Console.WriteLine("  [5] ➜ exit");
                    Console.ResetColor();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Select an option ➜ ");
                    Console.ResetColor();
                    string answer2 = Console.ReadLine();

                    if (answer2.ToLower().Trim() == "5")
                    {
                        break;
                    }

                    if (!int.TryParse(answer2, out int option))
                    {
                        message = "select a valid option";
                        continue;
                    }
                    if (option > 4 || option < 0)
                    {
                        message = "insert a valid option";
                        continue;
                    }

                    await Utilities.ModifyItem.Modifyitem(item, option);
                    Console.WriteLine("\nModify Item successfully");
                    Console.WriteLine("Press enter to continue.............................");
                    Console.ReadKey();
                }
            }

        }
    }
}
