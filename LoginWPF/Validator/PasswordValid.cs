using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class PasswordValid
    {
        PasswordIsNotEmpty passwordIsNotEmpty = new PasswordIsNotEmpty();
        PasswordLength passwordLength = new PasswordLength();
        PasswordIfContains passwordIfContains = new PasswordIfContains();

        public bool ValidatePassword(string password, Dictionary<string, string> dictionaryOfError)
        {
            if (passwordIsNotEmpty.ValidatePasswordIsNotEmpty(password, dictionaryOfError) && passwordLength.ValidatePasswordLength(password, dictionaryOfError) && passwordIfContains.ValidatePasswordIfContaining(password, dictionaryOfError))
                return true;

            return false;
        }

    }
}
