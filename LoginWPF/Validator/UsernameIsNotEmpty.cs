using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class UsernameIsNotEmpty
    {
        public bool ValidateUsernameEmpty(string username, Dictionary<string, string> dictionaryOfError)
        {
            if (username == null)
            {
                dictionaryOfError.Add("validateError", "Błąd! Puste pole Nazwa użytkownika.");
                return false;
            }

            return true;
        }
    }
}
