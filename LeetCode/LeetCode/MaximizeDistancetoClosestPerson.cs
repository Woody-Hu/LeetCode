using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximizeDistancetoClosestPerson
    {
        public int MaxDistToClosest(int[] seats)
        {
            int returnValue = 0;
            int lastIndex = -1;
            int nowIndex = 0;

            for (; nowIndex < seats.Length; nowIndex++)
            {
                if (1 == seats[nowIndex])
                {
                    returnValue = Math.Max(returnValue,lastIndex ==-1?nowIndex:(nowIndex-lastIndex)/2);
                    lastIndex = nowIndex;
                }
            }

            return Math.Max(returnValue, nowIndex - lastIndex -1);

        }
    }
}
