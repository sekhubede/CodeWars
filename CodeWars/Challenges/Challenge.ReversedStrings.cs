using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static string ReversedStrings(string str) => new string(str.Reverse().ToArray());
    }
}
