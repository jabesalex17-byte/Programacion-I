using Family_Shopping_List.Helpers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
bool running = true;
while (running)
{
    Console.Clear();

    // Título con estilo
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║        FAMILY SHOPPING LIST          ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.ResetColor();

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("  [1] ➜ Add Item");
    Console.WriteLine("  [2] ➜ View Shopping List");
    Console.WriteLine("  [3] ➜ Update an Item");
    Console.WriteLine("  [4] ➜ View Purchased Items");
    Console.WriteLine("  [5] ➜ Exit");
    Console.ResetColor();

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Select an option ➜ ");
    Console.ResetColor();

    if (!(int.TryParse(Console.ReadLine(), out int choice)))
    {
        continue;
    }
    switch (choice)
    {
        case 1:
            await Family_Shopping_List.Helpers.Forms.FormAddItem.formaddItem();
            break;
        case 2:
            await Family_Shopping_List.Helpers.Utilities.ViewShoppingList.ViewShoppinglist();
            break;
        case 3:
            await Family_Shopping_List.Helpers.Forms.FormModifyItem.Formmodifyitem();
            break;
        case 4:
            await Family_Shopping_List.Helpers.Utilities.ViewItemsPurchased.ViewItemspurchased();
            break;
        case 5:
            running = ConfirmExit.Confirmexit() ? false : true;
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}
