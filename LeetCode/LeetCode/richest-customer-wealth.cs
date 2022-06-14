using System;
using System.Linq;

namespace LeetCode
{
    public class richest_customer_wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            foreach (var item in accounts)
            {
                var sum = item.Sum();
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
