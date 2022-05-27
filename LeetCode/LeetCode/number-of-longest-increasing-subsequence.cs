using System;
namespace LeetCode
{
    public class number_of_longest_increasing_subsequence
    {
        public int FindNumberOfLIS(int[] nums)
        {
            var res = 0;
            var max = 0;
            var n = nums.Length;
            var dp = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = 1;
                dp[i, 1] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (dp[j, 0] + 1 > dp[i, 0] )
                        {
                            dp[i, 0] = dp[j, 0] + 1;
                            dp[i, 1] = dp[j, 1];
                        }
                        else if (dp[j, 0] + 1 == dp[i, 0])
                        {
                            dp[i, 1] += dp[j, 1];
                        }
                    }
                }

                if (dp[i, 0] > max)
                {
                    max = dp[i, 0];
                    res = dp[i, 1];
                }
                else if (dp[i, 0] == max)
                {
                    res += dp[i, 1];
                }
            }

            return res;
        }
    }
}
