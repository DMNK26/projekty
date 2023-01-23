using LoginWPF.Database.Context;
using LoginWPF.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class UsernameIsNotRepeat
    {
        public bool ValidateUsernameIsNotRepeat(string usernameValidate, Dictionary<string, string> dictionaryOfError)
        {
            UserDbContext userDbContext = new UserDbContext();
            User users = new User();

            bool query = userDbContext.Users.Any(u => u.login == usernameValidate);

            if (query)
            {
                dictionaryOfError.Add("validateError", "Błąd! Podana nazwa użytkownika jest zajęta.");
                return false;
            }
            else
                return true;
        }
    }
}
