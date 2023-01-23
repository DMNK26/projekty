using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace LoginWPF.Validator
{
    internal class PasswordIfContains
    {
        char[] specialSymbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+' };
        char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] uppercase = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
        char[] lowercase = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        public bool ValidatePasswordIfContaining(string password, Dictionary<string, string> dictionaryOfError)
        {
            if (!password.ToCharArray().Any(o => specialSymbols.Contains(o)))
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać znak specjalny!.");
                return false;
            }

            if (!password.ToCharArray().Any(o => numbers.Contains(o)))
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać cyfre!.");
                return false;
            }

            if (!password.ToCharArray().Any(o => uppercase.Contains(o)))
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać dużą litere!.");
                return false;
            }

            if (!password.ToCharArray().Any(o => lowercase.Contains(o)))
            {
                dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać małą litere!.");
                return false;
            }

            return true;
        }

        //public bool ValidatePasswordContainsSpecialSymbols(string password, Dictionary<string, string> dictionaryOfError)
        //{
        //	if (!password.ToCharArray().Any(o => specialSymbols.Contains(o)))
        //	{
        //              dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać znak specjalny!.");
        //              return false;
        //	}

        //	return true;
        //}

        //public bool ValidatePasswordContainsNumbers(string password, Dictionary<string, string> dictionaryOfError)
        //{
        //    if (!password.ToCharArray().Any(o => numbers.Contains(o)))
        //    {
        //        dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać cyfre!.");
        //        return false;
        //    }

        //    return true;
        //}

        //public bool ValidatePasswordContainsUppercaseLetter(string password, Dictionary<string, string> dictionaryOfError)
        //{
        //    if (!password.ToCharArray().Any(o => uppercase.Contains(o)))
        //    {
        //        dictionaryOfError.Add("validateError", "Błąd! Pole Hasło powinno zawierać dużą litere!.");
        //        return false;
        //    }

        //    return true;
        //}
    }
}
