using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _2_Keys_Keyboard
    {
        public int MinSteps(int n)
        {
            if (n <= 1)
            {
                return 0;
            }

            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = i;
                for (int j = 1; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[j] + i / j);
                    }
                }
            }

            return dp[n];
        }
    }
}
