using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.NumberOfPeopleInTheBusChallenge
{
    public class NumberOfPeopleInTheBus
    {
        public static int Solution(List<int[]> peopleListInOut) => peopleListInOut.Sum(stop => stop[0] - stop[1]);
    }
}
