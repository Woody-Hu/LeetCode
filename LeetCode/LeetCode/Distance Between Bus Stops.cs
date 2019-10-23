using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Distance_Between_Bus_Stops
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            var sum = distance.Sum();
            var sum2 = 0;
            var minIndex = Math.Min(start, destination);
            var maxIndex = Math.Max(start, destination);
            for (int i = minIndex; i < maxIndex; i++)
            {
                sum2 += distance[i];
            }

            var sum1 = sum - sum2;
            return Math.Min(sum1, sum2);
        }
    }
}
