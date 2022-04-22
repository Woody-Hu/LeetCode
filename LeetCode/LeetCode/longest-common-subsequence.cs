using System;
namespace LeetCode
{
    public class longest_common_subsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var n = text1.Length;
            var m = text2.Length;
            var dp = new int[n + 1, m + 1];
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            return dp[n, m];
        }
    }
}
