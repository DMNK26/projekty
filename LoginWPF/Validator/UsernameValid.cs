using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Validator
{
    internal class UsernameValid
    {
        UsernameIsNotEmpty usernameIsNotEmpty = new UsernameIsNotEmpty();
        UsernameLength usernameLength = new UsernameLength();
        UsernameIsNotRepeat usernameIsNotRepeat = new UsernameIsNotRepeat();

        public bool ValidateUsername(string username, Dictionary<string, string> dictionaryOfError)
        {
            if (usernameIsNotEmpty.ValidateUsernameEmpty(username, dictionaryOfError) && usernameLength.ValidateUsernameLength(username, dictionaryOfError) && usernameIsNotRepeat.ValidateUsernameIsNotRepeat(username,dictionaryOfError))
                return true;

            return false;
        }
    }
}
