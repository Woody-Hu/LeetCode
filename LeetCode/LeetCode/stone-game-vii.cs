using System;
namespace LeetCode
{
	public class stone_game_vii
	{
        public int StoneGameVII(int[] stones)
        {
            var n = stones.Length;
            var dp = new int[n, n];
            var cache = new int[n, n];
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    if (i == 2)
                    {
                        dp[j, j + i - 1] = Math.Max(stones[j], stones[j + i - 1]);
                        cache[j, j + i - 1] = stones[j] + stones[j + i - 1];
                    }
                    else
                    {
                        dp[j, j + i - 1] = Math.Max(cache[j, j + i - 2] - dp[j, j + i - 2], cache[j + 1, j + i - 1] - dp[j + 1, j + i - 1]);
                        cache[j, j + i - 1] = stones[j] + cache[j + 1, j + i - 1];
                    }
                }
            }

            return dp[0, n - 1];
        }
    }
}

