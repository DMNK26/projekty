using LoginWPF.Database.Context;
using LoginWPF.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class Validation
    {
        UsernameValid username = new UsernameValid();
        PasswordValid password = new PasswordValid();
        public bool Validate(string validateUsername, string validatePassword, Dictionary<string, string> dictionaryOfError)
        {
            if (username.ValidateUsername(validateUsername, dictionaryOfError) && password.ValidatePassword(validatePassword, dictionaryOfError))
                return true;

            return false;
        }
    }
}
