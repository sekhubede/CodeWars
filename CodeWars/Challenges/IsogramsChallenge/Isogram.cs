using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Challenges.IsogramsChallenge
{
    public class Isogram
    {
        public static bool Solution(string str) => str.ToLower().ToCharArray().Distinct().Count() == str.Length;
    }
}