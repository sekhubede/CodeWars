using System.Text.RegularExpressions;

namespace CodeWars.Challenges.RegexValidatePinCodeChallenge
{
    public class RegexValidatePinCode
    {
        public static bool Solution(string pin)
        {
            if (string.IsNullOrEmpty(pin))
            {
                return false;
            }

            string pattern = @"(^\d{4}$)|^\d{6}$";
            return Regex.IsMatch(pin, pattern);
        }

        public static bool Solution2(string pin) => 
            string.IsNullOrEmpty(pin) ? false : Regex.IsMatch(pin, @"(^\d{4}$)|^\d{6}$");
    }
}
