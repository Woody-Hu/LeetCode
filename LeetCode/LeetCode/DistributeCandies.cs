using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DistributeCandies
    {
        public int DistributeCandiesMethod(int[] candies)
        {
            int maxValue = candies.Length / 2;

            var groupValue = candies.GroupBy(k => k);

            return Math.Min(maxValue, groupValue.Count());


        }
    }
}
