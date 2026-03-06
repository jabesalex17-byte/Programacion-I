using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Xml.Linq;

bool runing = true;
List<int> ids = new List<int>();
List<int> Past_ids = new List<int>();
List<string> AnswerId = ["id", "ids", "idd"];
List<string> AnswerNum = ["numero", "num","enum","telephone","phone","number"];
List<string> affirmative = ["yes", "si", "1", "y", "s"];
List<string> negative = ["no", "not", "n", "2"];
List<string> SearchId = ["id", "su id"];
List<string> SearchPhone = ["numero", "phone", "telephone","number"];
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

while (runing)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------\nWelcome to my Contact List\n-----------------------------------------------\n");
    Console.WriteLine(@"1. Add Contact     2. View Contacts    3. Search Contacts     4. Edit Contact   5. Delete Contact    6. Exit");
    Console.WriteLine("\nEnter the number of the desired option");
    try
    {
        int typeOption = Convert.ToInt32(Console.ReadLine());
        switch (typeOption)
    {
        case 1:
            {

                FormulContact();

            }
            break;
        case 2: 
            {
                ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 3: 
            {
                SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 4: 
            {
                ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 5: 
            {
                DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends,Past_ids);
            }
            break;
        case 6:
            runing = false;
            break;
        default:
            break;
    }
    }
    catch
    {
        Console.Clear();
    }
}


void FormulContact()
{
    Console.Clear();
    Console.WriteLine("------------------------------------------\nAdd Contact\n-----------------------------------------------");
    string name = VerifyName();
    string lastname = VerifylastName();
    string address = VerifyAddress();
    string phone = VerifyTelephone();
    string email = VerifyEmail();
    int age = VerifyAge();
    bool isBestFriend = VerifyBerstfriend();
    string question = "\nAre you sure you want to add this contact?\n";

    bool confirm = ConfirmContact(name, lastname, address, phone, email, age, isBestFriend,question);
    
    if (confirm)
    {
        AddContact(name,lastname,address,phone,email,age,isBestFriend);
    }
}
void AddContact(string name, string lastname,  string  address ,  string phone , string email, int age ,bool isBestFriend)
{
    int id;

    if (ids.Count == 0)
    {
        id = 1;
    }
    else
    {
        id = ids[ids.Count - 1] + 1;
    }
    while (true)
    {
        if (Past_ids.Contains(id))
        {
            id++;
            continue;
        }
        else
        {
            break;
        }
    }
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}
bool ConfirmContact(string name, string lastname, string address, string phone, string email, int age, bool isBestFriend,string question)
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.WriteLine(question);
        string isBestFriendStr = IsBestfriendStr(isBestFriend);
        Console.WriteLine($"Name: {name} \nLast Name: {lastname} \nAddress: {address} \nPhone: {phone} \nEmail: {email} \nAge: {age} \nBest Friend: {isBestFriendStr}");
        string answer = Console.ReadLine();

        if (affirmative.Contains(answer.ToLower().Trim()))
        {
            return true;
        }
        else if (negative.Contains(answer.ToLower().Trim()))
        {
            return false;
        }
        else
        {
           message ="(yes or not, n o y, 1 o 2)";
           continue;
        }

    }
}
string VerifyName()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.WriteLine("\nEnter the person's name");
        string name = Console.ReadLine()!;
        if (name.Any(c => !char.IsLetter(c) && c != ' '))
        {
            message = "\nThe name can only contain letters";
            continue;
        }
        else if (name.Trim().Length == 1 || name.Trim().Length >= 16)
        {
            message = "The name must have between 2 and 15 characters";
            continue;
        }
        else if (name.Trim().Length == 0)
        {
            message = "Your name must contain at least 2 characters";
            continue;
        }

        return name;
    }
}
string VerifylastName()
{
    string menssage = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(menssage);

        Console.WriteLine("\nEnter the person's last name");
        string lastname = Console.ReadLine()!;
        if (lastname.Any(c => !char.IsLetter(c) && c != ' '))
        {
            menssage = "\nThe last name can only contain letters ";
            continue;
        }
        else if (lastname.Trim().Length == 1 || lastname.Trim().Length >= 16)
        {
            menssage = "The last name must have between 2 and 15 characters";
            continue;
        }
        else if (lastname.Trim().Length == 0)
        {
            menssage = "The last name cannot be empty";
            continue;
        }

        return lastname;
    }
}
string VerifyAddress()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        Console.WriteLine("\nEnter the address");
        string address = Console.ReadLine();

        if (address.Trim().Length <= 8 || address.Trim().Length >= 50)
        {
            message = "Your address must contain at least 8 characters and a maximum of 50";
            continue;
        }
        else if (address.Trim().Length == 0)
        {
            message = "The address cannot be empty";
            continue;
        }

        return address;
    }
}
string VerifyTelephone()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        Console.WriteLine("\nEnter the person's number without spaces\n\nexample +18092342220 or 8098129834");
        string phone = Console.ReadLine();

        int Caracter = phone.Count(x => x == '+');
        if (Caracter > 1)
        {
            message = "The number can only contain one + ";
            continue;
        }
        if (phone.Any(c => !char.IsDigit(c) && c != '+'))
        {
            message = "Invalid character (the only allowed character is + to indicate the country code)";
            continue;
        }
        else if (phone.Trim().Length <= 7 || phone.Trim().Length >= 20)
        {
            message = "Invalid number";
            continue;
        }

        return phone;
    }
}
string VerifyEmail()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        Console.WriteLine("\nEnter the person's email");
        string email = Console.ReadLine();

        try
        {
            MailAddress addr = new MailAddress(email);
            return email;
        }
        catch
        {
            message = "Invalid email";
            continue;
        }
    }
}
int VerifyAge()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        Console.WriteLine("\nEnter the person's age in numbers");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            message = "Enter a valid age";
            continue;
        }
        if (age < 5 || age > 85)
        {
            message = "Only people between 5 and 85 years old";
            continue;
        }

        return age;
    }
}
bool VerifyBerstfriend()
{
    string message = "";
    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        Console.WriteLine("\nIs this your Best Friend?");
        string answer = Console.ReadLine();

        if (affirmative.Contains(answer.ToLower().Trim()))
        {
            return true;
        }
        else if (negative.Contains(answer.ToLower().Trim()))
        {
            return false;
        }
        else
        {
            message = "Yes or No (y or n, 1 or 2)";
            continue;
        }
    }
}


void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    string message = "";
    bool exitF = true;
    while (true)
    {
        Console.Clear();
        ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, exitF);
        Console.WriteLine("Do you want to search by ID or by the person's number?\n\nType exit to leave");
        Console.WriteLine(message);
        message = "";
        string answer = Console.ReadLine();

        if (answer.ToLower().Trim() == "exit")
        {
            return;
        }

        if (AnswerId.Contains(answer.ToLower().Trim()))
        {
            SearchById();
            continue;
        } else if (AnswerNum.Contains(answer.ToLower().Trim()))
        {
            SearchByPhone();
            continue;
        }
        else
        {
            message = "Please enter the ID or number";
        }
    }
}
void SearchById()
{

    bool exitF = true;
    string messsage = "";
    while (true)
    {
        Console.Clear();
        ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, exitF);
        Console.WriteLine(messsage);
        messsage = "";
        Console.WriteLine("What is the ID of the person you want to view?\n\nType exit to go back\n");
        string answer = Console.ReadLine();

        if (answer.ToLower().Trim() == "exit")
        {
            return;
        }
        if (!int.TryParse(answer, out int search))
        {
            messsage = "Enter a number";
            continue;
        }
        if (!ids.Contains(search))
        {
            messsage = "There is no person with that ID";
            continue;
        }
        else
        {
            var result = ids.First(x => x == search);
            Search(result,names, lastnames, addresses, telephones, emails, ages, bestFriends);
            continue;
        }
    }
    
}
static void Search(int id, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Clear();
    Console.WriteLine();
    string header = $"{"Id",-4} | {"Name",-12} | {"Last Name",-12} | {"Address",-50} | {"Phone",-12} | {"Email",-35} | {"Age",-4} | {"Best Friend",-12}";

    Console.WriteLine();
    Console.WriteLine(header);
    Console.WriteLine(new string('-', header.Length));

    string isBestFriendStr = IsBestfriendStr(bestFriends[id]);

    Console.WriteLine($"{id,-4} | {names[id],-12} | {lastnames[id],-12} | {addresses[id],-50} | {telephones[id],-12} | {emails[id],-35} | {ages[id],-4} | {isBestFriendStr,-12}");

    Console.Write("Press enter to continue..................");
    Console.ReadKey();
}
void SearchByPhone()
{
    string message = "";
    bool exitF = true;
    while (true)
    {
        Console.Clear();
        ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, exitF);
        Console.WriteLine(message);
        Console.WriteLine("What is the phone number of the person you want to search for?\n\nType exit to go back");
        string answer = Console.ReadLine();

        if (answer.ToLower().Trim() == "exit")
        {
            return;
        }
        if (answer.Any(c => !char.IsDigit(c) && c != ' ' && c != '+'))
        {
            message = "Enter a valid number";
            continue;
        }
        if (!telephones.ContainsValue(answer.Trim()))
        {
            message = "That number does not exist";
            continue;
        }

        var result = telephones.First(x => x.Value == answer);
        Search(result.Key, names, lastnames, addresses, telephones, emails, ages, bestFriends);
    }
}

static void ViewContacList(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends ,bool exitFast = false)
{
    Console.Clear();
    Console.WriteLine();

    string header = $"{"Id",-4} | {"Name",-12} | {"Last Name",-12} | {"Address",-50} | {"Phone",-12} | {"Email",-35} | {"Age",-4} | {"Best Friend",-12}";

    Console.WriteLine();
    Console.WriteLine(header);
    Console.WriteLine(new string('-', header.Length));

    foreach (var id in ids)
    {
        string isBestFriendStr = IsBestfriendStr(bestFriends[id]);

        Console.WriteLine(
        $"{id,-4} | {names[id],-12} | {lastnames[id],-12} | {addresses[id],-50} | {telephones[id],-12} | {emails[id],-35} | {ages[id],-4} | {isBestFriendStr,-12}"
        );
    }

    if (exitFast == false)
    {
        Console.Write("\nPress enter to continue...");
        Console.ReadKey();
    }
}

void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    string message = "";
    bool exitF = true;
    int id;
    int information =0;
    while (true)
    {
        while (true)
        {
            Console.Clear();
            ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, exitF);
            Console.WriteLine(message);
            Console.WriteLine("What is the ID of the person you want to modify?\n\nexit to leave");

            string answer = CheckId(ids);
            if (answer == "enter a valid id" || answer == "that id does not exist" || answer == "enter an id")
            {
                message = answer;

                continue;
            }
            if (answer.ToLower().Trim() == "exit")
            {
                return;
            }
            if ((answer.ToLower().Trim() != "enter a valid id" && answer.ToLower().Trim() != "that id does not exist") || answer.ToLower().Trim() == "")
            {
                int.TryParse(answer, out id);
                break;
            }
        }
        message = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Type the number of what you want to modify\n\nexit to leave");
            Console.WriteLine(message);
            Console.WriteLine("1.Name \n2.Last Name\n3.Address\n4.Phone\n5.Email\n6.Age\n7.Best Friend\n8. Modify all");
            string answer = CheckInformation();
            if (answer.ToLower().Trim() == "exit")
            {
                break;
            }
            if (answer == "Enter a valid number" || answer == "enter one of the options" || answer == "enter a number")
            {
                message = answer;
                continue;
            }
            else
            {
                int.TryParse(answer, out information);
                
            }
            modifyInformation(id, information);
        }

    }

} 
static string CheckId(List<int> ids)
{
    string message = "";
    string answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "exit")
    {
        return "exit";
    }
    if (answer.Trim() == "")
    {
        return "enter an id";
    }
    if (!int.TryParse(answer, out int id))
    {
        return "enter a valid id";
    }
    else if (!ids.Contains(id))
    {
        return "that id does not exist";
    }
    else
    {
        return id.ToString();
    }
}
static string CheckInformation()
{
    string message = "";
    string answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "exit")
    {
        return "exit";
    }
    if (answer.ToLower().Trim() == "")
    {
        return "enter a number";
    }
    if (!int.TryParse(answer, out int information))
    {
        message = "Enter a valid number";
        return message;

    }
    if (information < 1 || information > 8)
    {
        message = "enter one of the options";
        return message;
    }
    else
    {
        return information.ToString();
    }
}
void modifyInformation(int id, int information)
{
    switch (information)
    {
        case 1:
            {
                string NewName = VerifyName();
                modifyName(id, NewName);
                break;
            }
        case 2:
            {
                string NewLastname = VerifylastName();
                modifyLastname(id, NewLastname);
                break;
            }
        case 3:
            {
                string NewAddress = VerifyAddress();
                modifyAddress(id, NewAddress);
                break;
            }
        case 4:
            {
                string NewPhone = VerifyTelephone();
                modifyTelephones(id, NewPhone);
                break;
            }
        case 5:
            {
                string NewEmail = VerifyEmail();
                modifyTelephones(id, NewEmail);
                break;
            }
        case 6:
            {
                int NewAge = VerifyAge();
                modifyAges(id, NewAge);
                break;
            }
        case 7:
            {
                bool NewIsbestfriend = VerifyBerstfriend();
                modifyBestfriend(id, NewIsbestfriend);
                break;
            }
        case 8:
            {
                string NewName = VerifyName();
                modifyName(id, NewName);

                string NewLastname = VerifylastName();
                modifyLastname(id, NewLastname);

                string NewAddress = VerifyAddress();
                modifyAddress(id, NewAddress);

                string NewPhone = VerifyTelephone();
                modifyTelephones(id, NewPhone);

                string NewEmail = VerifyEmail();
                modifyTelephones(id, NewEmail);

                int NewAge = VerifyAge();
                modifyAges(id, NewAge);

                bool NewIsbestfriend = VerifyBerstfriend();
                modifyBestfriend(id, NewIsbestfriend);

                break;
            }
    }
}
void modifyName(int id, string information)
{
    names[id] = information;
}
void modifyLastname(int id,  string information)
{
    lastnames[id] = information;
}
void modifyAddress(int id, string information)
{
    addresses[id] = information;
}
void modifyTelephones(int id, string information)
{
    telephones[id] = information;
}
void modifyEmails(int id, string information)
{
    addresses[id] = information;
}
void modifyAges(int id, int information)
{
    ages[id] = information;
}
void modifyBestfriend(int id, bool information)
{
    bestFriends[id] = information;
}



void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends, List<int> Past_ids)
{
    string message = "";
    bool exitF = true;
    string question = "Are you sure you want to delete this contact?";
    while (true)
    {
        Console.Clear();
        ViewContacList(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, exitF);
        Console.WriteLine(message);
        message = "";
        Console.WriteLine("What is the ID of the person you want to delete?\n\nexit to leave");

        string answer = CheckId(ids);
        if (answer == "enter a valid id" || answer == "that id does not exist" || answer == "enter an id")
        {
            message = answer;

            continue;
        }
        if (answer.ToLower().Trim() == "exit")
        {
            return;
        }
        if ((answer.ToLower().Trim() != "enter a valid id" && answer.ToLower().Trim() != "that id does not exist") || answer.ToLower().Trim() == "")
        {
            int.TryParse(answer, out int id);
            bool delete = ConfirmContact(names[id], lastnames[id], addresses[id], telephones[id], emails[id], ages[id], bestFriends[id], question);
            DeleteInformation(id, delete);
        }
    }

}
void DeleteInformation(int id, bool Delete)
{

    if (Delete)
    {
        ids.Remove(id);
        names.Remove(id);
        lastnames.Remove(id);
        addresses.Remove(id);
        telephones.Remove(id);
        ages.Remove(id);
        emails.Remove(id);
        bestFriends.Remove(id);
        PastIds(Past_ids, id);
    }
}


static string IsBestfriendStr(bool bestfriend)
{
    return bestfriend ? "Yes" : "No";
}
static void PastIds(List<int> Past_ids,int id)
{
    Past_ids.Add(id);
}
