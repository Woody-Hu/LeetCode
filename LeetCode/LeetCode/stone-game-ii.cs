using System;
namespace LeetCode
{
    public class stone_game_ii
    {
        public int StoneGameII(int[] piles)
        {
            var len = piles.Length;
            var sum = 0;
            var dp = new int[len, len + 1];
            for (int i = len - 1; i >= 0; i--)
            {
                sum += piles[i];
                for (int m = 1; m <= len; m++)
                {
                    if (i + 2 * m >= len)
                    {
                        dp[i, m] = sum;
                    }
                    else
                    {
                        for (int x = 1; x <= 2*m; x++)
                        {
                            dp[i, m] = Math.Max(dp[i, m], sum - dp[i + x, Math.Max(m, x)]);
                        }
                    }
                }
            }

            return dp[0, 1];
        }
    }
}
