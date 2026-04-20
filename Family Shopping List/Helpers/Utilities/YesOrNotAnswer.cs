using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Utilities
{
    internal class YesOrNotAnswer
    {
        public static List<string> yes = ["yes","y","si","s","1"];
        public static List<string> not = ["no","not","n","2"];
        public static bool YesOrNotanswer()
        {
            while (true)
            {
                string answer = Console.ReadLine()!;
                if (YesOrNotAnswer.yes.Contains(answer.ToLower().Trim()))
                {
                    return true;
                }
                else if (YesOrNotAnswer.not.Contains(answer.ToLower().Trim()))
                {
                    return false;
                }
            }
        }
    }
}
