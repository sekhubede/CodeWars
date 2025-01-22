using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.ReversedStringChallenge
{
    public class ReversedString
    {
        public static string Solution(string str) => new string(str.Reverse().ToArray());
    }
}
