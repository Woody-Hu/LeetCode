using System;

namespace LeetCode;

public class minimum_difficulty_of_a_job_schedule
{
    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n = jobDifficulty.Length;
        if (n < d) {
            return -1;
        }
        int[][] dp = new int[d + 1][];
        for (int i = 0; i <= d; ++i) {
            dp[i] = new int[n];
            Array.Fill(dp[i], 0x3f3f3f3f);
        }
        int ma = 0;
        for (int i = 0; i < n; ++i) {
            ma = Math.Max(ma, jobDifficulty[i]);
            dp[0][i] = ma;
        }
        for (int i = 1; i < d; ++i) {
            for (int j = i; j < n; ++j) {
                ma = 0;
                for (int k = j; k >= i; --k) {
                    ma = Math.Max(ma, jobDifficulty[k]);
                    dp[i][j] = Math.Min(dp[i][j], ma + dp[i - 1][k - 1]);
                }
            }
        }
        return dp[d - 1][n - 1];
    }
}