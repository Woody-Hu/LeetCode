using System;

namespace LeetCode;

public class palindrome_partitioning_iii
{
    public int PalindromePartition(string s, int k) {
        var n = s.Length;
        var dp = new int[n + 1, k + 1];
        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j <= k; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }
        
        dp[0, 0] = 0;
        var cost = new int[n, n];
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                cost[i, j] = 0;
                var left = i;
                var right = j;
                while (left < right)
                {
                    if (s[left] != s[right])
                    {
                        cost[i, j]++;
                    }
                    left++;
                    right--;
                }
            }
        }
        
        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= k; j++)
            {
                for (var x = 0; x < i; x++)
                {
                    if (dp[x, j - 1] != int.MaxValue)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[x, j - 1] + cost[x, i - 1]);
                    }
                }
            }
        }
        
        return dp[n, k];
    }
}