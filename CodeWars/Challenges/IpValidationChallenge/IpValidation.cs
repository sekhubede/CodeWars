using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;

namespace CodeWars.Challenges.IpValidationChallenge
{
    public class IpValidation
    {
        public static bool Solution(string ipAddres)
        {
            // Check if there are any spaces anywhere inside the IP address
            if (ipAddres.Contains(' '))
                return false;

            // Split the string using '.' as the delimiter
            var octets = ipAddres.Split('.');

            // Must have exactly 4 parts
            if (octets.Length != 4)
                return false;

            foreach (var octet in octets)
            {
                // Check if part is empty or contains invalid characters
                if (string.IsNullOrEmpty(octet) || !int.TryParse(octet, out int num) || octet.Length > 1 && octet[0] == '0')
                    return false;

                // Check if the number is in range (0 to 255)
                if (num < 0 || num > 255)
                    return false;
            }

            return true;
        }


        public static bool Solution2(string ip)
        {
            string pattern = @"^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$";
            return Regex.IsMatch(ip, pattern);
        }
    }
}
