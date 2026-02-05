//Jabes Estevez 2025-0905
List<string> answers = ["yes","si","y","ye","ss"];
while (true)
{
    Console.Clear();
        Console.WriteLine("insert a number");
        if(!int.TryParse(Console.ReadLine(), out int num))
        {
            continue;
        }
        Console.WriteLine(VerifyNumber(num));
        Console.WriteLine("\nDo you wanna exit?");
        string answer = Console.ReadLine()!;
        if (answers.Contains(answer.ToLower().Trim())){
            break;
        }
}
static string VerifyNumber(int x)
{
    if(x == 0)
    {
        return "The number is  invalid";
    }
    var message = x % 2 == 0 ? "The number is par" : "The number is impar";
    return message;
}

