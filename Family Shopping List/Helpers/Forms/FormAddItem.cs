using Family_Shopping_List.Helpers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Shopping_List.Helpers.Forms
{
    public class FormAddItem
    {
        static int idCount = 1;
        static string question = "are you sure you want to add this item";
        public static async Task formaddItem()
        {
            Console.Clear();
            string title = "Adding item";
            string name = Verifyfield.VerifyName.Verifyname(title);
            int amount = Verifyfield.VerifyAmount.Verifyamount(title);
            string note = Verifyfield.VerifyNote.Verifynote(title);
            bool state =Verifyfield.VerifyState.Verifystate(title);


            if (ConfirmItem.Confirmpatient(name,amount,state,note,question))
            {
                await CreateItem.Createpatient(name, amount, note, state);
            }
        }
    }
}
