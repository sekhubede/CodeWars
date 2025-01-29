using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Challenges.ReturnNegativeChallenge
{
    public class ReturnNegative
    {
        public static int Solution(int number)
        {
            return number < 0 ? number : -number;
        }
    }
}