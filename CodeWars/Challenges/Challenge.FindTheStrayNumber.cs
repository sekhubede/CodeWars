using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        // If the first element is the same as the second, return the number that differs
        public static int Stray(int[] numbers) =>  numbers[0] == numbers[1] ?
                                                   numbers.First(n => n != numbers[0]) :
                                                   numbers[0] == numbers[2] ? numbers[1] : numbers[0];

        public static int StrayEx(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
        }
    }
}
