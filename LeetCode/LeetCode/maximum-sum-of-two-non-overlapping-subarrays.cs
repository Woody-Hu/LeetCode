using System;
namespace LeetCode
{
    public class maximum_sum_of_two_non_overlapping_subarrays
    {
        public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
        {
            var l = nums.Length;
            var res = 0;
            var sum = new int[l + 1];
            for (int i = 0; i < l; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
            }

            if (firstLen > secondLen)
            {
                var temp = firstLen;
                firstLen = secondLen;
                secondLen = temp;
            }

            var dp = new int[l + 1, 2];
            for (int i = firstLen; i <= l; i++)
            {
                var s1 = sum[i] - sum[i - firstLen];
                dp[i, 0] = Math.Max(dp[i - 1, 0], s1);
                res = Math.Max(res, s1 + dp[i - firstLen, 1]);
                if (i >= secondLen)
                {
                    var s2 = sum[i] - sum[i - secondLen];
                    dp[i, 1] = Math.Max(dp[i - 1, 1], s2);
                    res = Math.Max(res, s2 + dp[i - secondLen, 0]);
                }
            }

            return res;

        }
    }
}
