using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1990 &&
                gamer.FirstName == "Nurullah" &&
                gamer.LastName == "Demirci" &&
                gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
        }
    }
}
