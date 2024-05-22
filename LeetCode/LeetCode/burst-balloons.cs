using System;

namespace LeetCode;

public class burst_balloons
{
    public int MaxCoins(int[] nums) {
        var n = nums.Length;
        var dp = new int[n + 2, n + 2];
        var newNums = new int[n + 2];
        newNums[0] = newNums[n + 1] = 1;
        for (var i = 1; i <= n; i++)
        {
            newNums[i] = nums[i - 1];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = i + 2; j <= n + 1; j++)
            {
                for (int k = i + 1; k < j; k++)
                {
                    var sum = newNums[i] * newNums[k] * newNums[j];
                    sum += dp[i, k] + dp[k, j];
                    dp[i, j] = Math.Max(dp[i, j], sum);
                }
            }
        }
        
        return dp[0, n + 1];



    }
}