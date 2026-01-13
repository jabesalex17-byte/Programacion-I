List<string> answers = ["yes","si","y","ye"];
while (true)
{
    Console.Clear();
    try
    {

        Console.WriteLine("insert a number");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(VerifyNumber(num));
      
        Console.WriteLine("\nDo you wanna exit?");
        string answer = Console.ReadLine()!;
        if (answers.Contains(answer.ToLower().Trim())){
            break;
        }

    }
    catch
    {
        continue;
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