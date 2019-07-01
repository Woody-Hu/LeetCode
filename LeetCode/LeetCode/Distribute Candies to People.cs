using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Distribute_Candies_to_People
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            var res = new int[num_people];

            for (int i = 0; candies > 0; i++)
            {
                res[i % num_people] += Math.Min(candies, i + 1);
                candies -= i + 1;
            }

            return res;
        }
    }
}
