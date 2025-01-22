using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int peopleOnBus = 0;

            foreach(var stop in peopleListInOut)
            {
                peopleOnBus += stop[0] - stop[1];
            }

            return peopleOnBus;
        }
    }
}
