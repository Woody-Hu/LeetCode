using System;
namespace LeetCode
{
    public class minimum_ascii_delete_sum_for_two_strings
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            var l1 = s1.Length;
            var l2 = s2.Length;
            var dp = new int[l1 + 1, l2 + 1];
            for (int i = l1 - 1; i >= 0; i--)
            {
                dp[i, l2] = dp[i + 1, l2] + s1[i];
            }

            for (int i = l2 - 1; i >= 0; i--)
            {
                dp[l1, i] = dp[l1, i + 1] + s2[i];
            }

            for (int i = l1 - 1; i >= 0; i--)
            {
                for (int j = l2 - 1; j >= 0; j--)
                {
                    if (s1[i] == s2[j])
                    {
                        dp[i, j] = dp[i + 1, j + 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(s1[i] + dp[i + 1, j], s2[j] + dp[i, j + 1]);
                    }
                }
            }

            return dp[0, 0];
        }
    }
}
