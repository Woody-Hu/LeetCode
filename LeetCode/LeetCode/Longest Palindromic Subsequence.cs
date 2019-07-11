using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Longest_Palindromic_Subsequence
    {
        public int LongestPalindromeSubseq(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var dp = new int[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = 1;
            }

            for (int i = s.Length - 1; i >=0; i--)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i,j] = 2+dp[i+1,j-1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[0, s.Length - 1];
        }
    }
}
