
using Opcional_Task.Helpers.Forms;
using Opcional_Task.Helpers.utilities;
using Opcional_Task.Patients;
using Opcional_Task.Services;
using AppPatient = Opcional_Task.Data.DbContextPatients;
bool running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------\nList Patient\n------------------------------------------\n");
    Console.Write("1. Agregar Contacto      ");
    Console.Write("2. Ver Contactos     ");
    Console.Write("3. Buscar Contactos      ");
    Console.Write("4. Modificar Contacto        ");
    Console.Write("5. Eliminar Contacto     ");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");


    if (!(int.TryParse(Console.ReadLine(), out int choice)))
    {
        continue;
    }
    switch (choice)
    {
        case 1:
            await FormAddPatient.formaddPatient(); ;
            break;
        case 2:
            //ViewList.Viewlist();
            await ViewListPatients.ViewListpatients();
            break;
        case 4:
            await FormModifyPatient.FormmodifyPatient();
            //FormModifyContact.Formodifycontact();
            break;
        case 5:
            await FormDeleteContact.FormdeleteContact();
            //FormDeleteContact.DeleteContact();
            break;
        case 3:
            await FormSearchContact.FormsearchContact();
            break;
        case 6:
            running = ConfirmExit.Confirmexit() ? false : true;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}