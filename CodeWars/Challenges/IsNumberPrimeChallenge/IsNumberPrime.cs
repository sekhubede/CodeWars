using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.IsNumberPrimeChallenge
{
    public class IsNumberPrime
    {
        public static bool Solution(int n)
        {
            // Edge case: numbers <= 1 are not prime
            if (n <= 1) return false;

            // Special case: 2 is prime
            if (n == 2) return true;

            // Even numbers greater than 2 are not prime
            if (n % 2 == 0) return false;

            // Check only odd numbers up to the square root of n
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            // If no divisors found, n is prime
            return true;
        }
    }
}
