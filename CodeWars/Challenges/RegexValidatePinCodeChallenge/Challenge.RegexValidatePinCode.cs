using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static bool ValidatePin(string pin)
        {
            if (string.IsNullOrEmpty(pin))
            {
                return false;
            }

            string pattern = @"(^\d{4}$)|^\d{6}$";
            return Regex.IsMatch(pin, pattern);
        }

        public static bool ValidatePinEx(string pin) => 
            string.IsNullOrEmpty(pin) ? false : Regex.IsMatch(pin, @"(^\d{4}$)|^\d{6}$");
    }
}
