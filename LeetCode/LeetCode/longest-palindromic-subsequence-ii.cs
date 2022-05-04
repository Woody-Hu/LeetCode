using System;
namespace LeetCode
{
    public class longest_palindromic_subsequence_ii
    {
        public int LongestPalindromeSubseq(string s)
        {
            var n = s.Length;
            var dp = new int[n + 2, n + 2, 2];
            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < n + 2; j++)
                {
                    dp[i, j, 1] = -1;
                }
            }

            var res = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    if (s[i - 1] == s[j - 1] && (s[i - 1] - 'a') != dp[i - 1, j + 1, 1])
                    {
                        dp[i, j, 0] = dp[i - 1, j + 1, 0] + 2;
                        dp[i, j, 1] = s[i - 1] - 'a';
                        res = Math.Max(res, dp[i, j, 0]);
                    }
                    else
                    {
                        dp[i, j, 0] = Math.Max(dp[i - 1, j, 0], dp[i, j + 1, 0]);
                        dp[i, j, 1] = dp[i - 1, j, 0] > dp[i, j + 1, 0] ? dp[i - 1, j, 1] : dp[i, j + 1, 1];
                    }

                }
            }
            return res;
        }
    }
}
