using System;

namespace LeetCode;

public class GzCJIP
{
    public int MinCostClimbingStairs(int[] cost) {
        var n = cost.Length;
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 0;
        for (int i = 2; i <= n; i++)
        {
            dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
        }
        
        return dp[n];

    }
}