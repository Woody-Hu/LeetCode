using System;
namespace LeetCode
{
	public class domino_and_tromino_tiling
	{
        public int NumTilings(int n)
        {
            const int mod = 1000000007;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = new int[4];
            }

            dp[0][3] = 1;
            for (int i = 1; i <= n; i++)
            {
                dp[i][0] = dp[i - 1][3];
                dp[i][1] = (dp[i - 1][0] + dp[i - 1][2]) % mod;
                dp[i][2] = (dp[i - 1][0] + dp[i - 1][1]) % mod;
                dp[i][3] = (((dp[i - 1][0] + dp[i - 1][1]) % mod + dp[i - 1][2]) % mod + dp[i - 1][3]) % mod;
            }

            return dp[n][3];
        }
    }
}

