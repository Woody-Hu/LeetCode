using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Two_City_Scheduling
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            Array.Sort(costs, (a, b) => (a[0] - a[1]) - (b[0] - b[1]));
            var sum = 0;
            var n = costs.GetLength(0) / 2;
            for (int i = 0; i <= n; i++)
            {
                sum += costs[i][0] + costs[i + n][1];
            }

            return sum;
        }
    }
}
