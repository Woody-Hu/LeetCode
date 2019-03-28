using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Integer_Break
    {
        public int IntegerBreak(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    dp[i] = Math.Max(dp[i], (Math.Max(j, dp[j])) * (Math.Max(i - j, dp[i - j])));
                }
            }
            return dp[n];
        }
    }
}
