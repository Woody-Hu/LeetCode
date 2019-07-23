using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Coin_Change_2
    {
        public int Change(int amount, int[] coins)
        {
            var length = coins.Length;
            var dp = new int[amount + 1];
            dp[0] = 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    if (coins[i] <= j)
                    {
                        dp[j] = dp[j] + dp[j - coins[i]];
                    }
                }
            }

            return dp[amount];
        }
    }
}
