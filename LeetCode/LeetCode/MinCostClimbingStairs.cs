using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinCostClimbingStairs
    {
        public int MinCostClimbingStairsMethod(int[] cost)
        {
            int[] returnValues = new int[cost.Length +1 ];

            returnValues[0] = cost[0];

            returnValues[1] = cost[1];


            for (int i = 2; i <= cost.Length; i++)
            {
                int useCost = i == cost.Length ? 0 : cost[i];

                returnValues[i] = Math.Min(useCost + returnValues[i - 1], useCost + returnValues[i - 2]);
            }

            return returnValues[cost.Length];
        }
    }
}
