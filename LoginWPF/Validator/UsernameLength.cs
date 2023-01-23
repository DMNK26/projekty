using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class UsernameLength
    {
        public bool ValidateUsernameLength(string username, Dictionary<string, string> dictionaryOfError)
        {
            if (username == null || username.Length > 15)
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Nazwa użytkownika powinno zawierać maksymalnie 15 znaków.");
                return false;
            }

            return true;
        }
    }
}
