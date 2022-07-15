using System;
namespace LeetCode
{
    public class uncrossed_lines
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var m = nums2.Length;
            var dp = new int[n + 1, m + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - 1] + 1);
                    }
                }
            }

            return dp[n, m];
        }
    }
}
