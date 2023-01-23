using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class PasswordLength
    {
        public bool ValidatePasswordLength(string password, Dictionary<string, string> dictionaryOfError)
        {
            if (password == null || password.Length < 8)
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać łącznie 8 znaków.");
                return false;
            }

            return true;
        }
    }
}
