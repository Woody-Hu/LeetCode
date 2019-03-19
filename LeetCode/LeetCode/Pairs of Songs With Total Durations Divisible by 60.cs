using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Pairs_of_Songs_With_Total_Durations_Divisible_by_60
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            var array = new int[60];
            var count = 0;
            foreach (var item in time)
            {
                count += array[(60 - item % 60) % 60];
                array[item % 60]++;
            }

            return count;
        }
    }
}
