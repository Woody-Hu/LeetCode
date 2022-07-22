using System;
namespace LeetCode
{
    public class egg_drop_with_2_eggs_and_n_floors
    {
        public int TwoEggDrop(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                var min = int.MaxValue;
                for (int j = 1; j <= i; j++)
                {
                    min = Math.Min(Math.Max(dp[i - j] + 1, j), min);
                }

                dp[i] = min;
            }

            return dp[n];
        }
    }
}
