using System;
using System.Linq;

namespace LeetCode
{
    public class last_stone_weight_ii
    {
        public int LastStoneWeightII(int[] stones)
        {
            var sum = stones.Sum();
            var mid = sum / 2;
            var n = stones.Length;
            var dp = new bool[n + 1, mid + 1];
            dp[0, 0] = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= mid; j++)
                {
                    if (stones[i] > j)
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                    else
                    {
                        dp[i + 1, j] = dp[i, j] || dp[i, j - stones[i]];
                    }
                }
            }

            for (int j = mid; ; --j)
            {
                if (dp[n, j])
                {
                    return sum - 2 * j;
                }
            }

            return -1;
        }
    }
}
