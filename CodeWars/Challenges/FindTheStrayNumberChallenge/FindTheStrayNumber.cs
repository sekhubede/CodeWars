using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.FindTheStrayNumberChallenge
{
    public class FindTheStrayNumber
    {
        // If the first element is the same as the second, return the number that differs
        public static int Solution(int[] numbers) =>  numbers[0] == numbers[1] ?
                                                   numbers.First(n => n != numbers[0]) :
                                                   numbers[0] == numbers[2] ? numbers[1] : numbers[0];

        public static int Solution2(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
        }
    }
}
