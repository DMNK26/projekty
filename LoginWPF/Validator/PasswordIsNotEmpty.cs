using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class PasswordIsNotEmpty
    {
        public bool ValidatePasswordIsNotEmpty(string password, Dictionary<string, string> dictionaryOfError)
        {
            if (password == null)
            {
                dictionaryOfError.Add("validateError", "Błąd! Puste pole Hasło.");
                return false;
            }

            return true;
        }
    }
}
