using LoginWPF.Database.Context;
using LoginWPF.Model.Entities;
using LoginWPF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class UsernameAndPasswordCorrect
    {
        public bool ValidationUsernameAndPasswordCorrect(string username, string password, Dictionary<string, string> dictionaryOfError)
        {
            UserDbContext userDbContext = new UserDbContext();
            User users = new User();
            Queries queries = new Queries();

            if(queries.UsernameQuery(username) == false)
            {
                dictionaryOfError.Add("validateError", "Błąd! Nieprawidłowa nazwa użytkownika.");
                return false;
            }

            if(queries.PasswordQuery(username) != password)
            {
                dictionaryOfError.Add("validateError", "Błąd! Nieprawidłowe hasło.");
                return false;
            }

            return true;
        }
    }
}
