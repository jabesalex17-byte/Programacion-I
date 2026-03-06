using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Helpers.utilities;
using Task_4.Domain;

namespace Task_4.Helpers.utilities;
public class ModifyInformation
{
    public static void modifyInformation(int id, int information)
    {
        switch (information)
        {
            case 1:
                {
                    string NewName = Verifyfield.VerifyName.Verifyname();
                    ModifyContact.modifyName(id, NewName);
                    break;
                }
            case 2:
                {
                    string NewLastname = Verifyfield.VerifyLastName.VerifylastName();
                    ModifyContact.modifyLastname(id, NewLastname);
                    break;
                }
            case 3:
                {
                    string NewAddress = Verifyfield.VerifyAddress.Verifyaddress();
                    ModifyContact.modifyAddress(id, NewAddress);
                    break;
                }
            case 4:
                {
                    string NewPhone = Verifyfield.VerifyTelephone.Verifytelephone();
                    ModifyContact.modifyTelephones(id, NewPhone);
                    break;
                }
            case 5:
                {
                    string NewEmail = Verifyfield.VerifyEmail.Verifyemail();
                    ModifyContact.modifyEmails(id, NewEmail);
                    break;
                }
            case 6:
                {
                    int NewAge = Verifyfield.VerifyAges.VerifyAge();
                    ModifyContact.modifyAges(id, NewAge);
                    break;
                }
            case 7:
                {
                    bool NewIsbestfriend = Verifyfield.VerifyBestFriend.VerifyBerstfriend();
                    ModifyContact.modifyBestfriend(id, NewIsbestfriend);
                    break;
                }
            case 8:
                {
                    string NewName = Verifyfield.VerifyName.Verifyname();
                    ModifyContact.modifyName(id, NewName);

                    string NewLastname = Verifyfield.VerifyLastName.VerifylastName();
                    ModifyContact.modifyLastname(id, NewLastname);

                    string NewAddress = Verifyfield.VerifyAddress.Verifyaddress();
                    ModifyContact.modifyAddress(id, NewAddress);

                    string NewPhone = Verifyfield.VerifyTelephone.Verifytelephone();
                    ModifyContact.modifyTelephones(id, NewPhone);

                    string NewEmail = Verifyfield.VerifyEmail.Verifyemail();
                    ModifyContact.modifyEmails(id, NewEmail);

                    int NewAge = Verifyfield.VerifyAges.VerifyAge();
                    ModifyContact.modifyAges(id, NewAge);

                    bool NewIsbestfriend = Verifyfield.VerifyBestFriend.VerifyBerstfriend();
                    ModifyContact.modifyBestfriend(id, NewIsbestfriend);

                    break;
                }
        }
    }
}
