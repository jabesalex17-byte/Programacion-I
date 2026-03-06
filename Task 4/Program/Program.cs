using Task_4.Domain;
using Task_4.Helpers.Forms;
bool running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------------\nWelcome to My Contact List\n-----------------------------------------\n");
    Console.Write("1. Add Contact      ");
    Console.Write("2. View Contacts     ");
    Console.Write("3. Search Contacts      ");
    Console.Write("4. Modify Contact        ");
    Console.Write("5. Delete Contact     ");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");


    if (!(int.TryParse(Console.ReadLine(), out int choice)))
    {
        continue;
    }
    switch (choice)
    {
        case 1:
            FormAddContact.FormulContact();
            break;
        case 2:
            ViewList.Viewlist();
            break;
        case 4:
            FormModifyContact.Formodifycontact();
            break;
        case 5:
            FormDeleteContact.DeleteContact();
            break;
        case 3: 
            FormSearchContact.SearchContact();
            break;
        case 6:
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}