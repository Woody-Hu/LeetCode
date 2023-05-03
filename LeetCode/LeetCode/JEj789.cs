using System;
using System.Linq;

namespace LeetCode
{
	public class JEj789
	{
        public int MinCost(int[][] costs)
        {
            var n = costs.Length;
            var dp = new int[3];
            for (int i = 0; i < 3; i++)
            {
                dp[i] = costs[0][i]; 
            }

            for (int i = 1; i < n; i++)
            {
                var newDp = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    newDp[j] = Math.Min(dp[(j + 1) % 3], dp[(j + 2) % 3]) + costs[i][j];
                }

                dp = newDp;
            }

            return dp.Min();
        }
    }
}

