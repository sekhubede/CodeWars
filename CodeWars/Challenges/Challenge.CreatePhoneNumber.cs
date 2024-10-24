using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        private const string _phoneNumberFormat = @"({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}";

        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }

        public static string CreatePhoneNumberLinq(int[] numbers)
        {
            return string.Format(_phoneNumberFormat, numbers.Select(x => x.ToString()).ToArray());
        }

        public static string CreatePhoneNumberEx(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
