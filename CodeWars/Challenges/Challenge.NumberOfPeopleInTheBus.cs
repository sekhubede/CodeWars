using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static int Number(List<int[]> peopleListInOut) => peopleListInOut.Sum(stop => stop[0] - stop[1]);
    }
}
