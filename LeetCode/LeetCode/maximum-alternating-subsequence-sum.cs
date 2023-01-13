using System;
namespace LeetCode
{
    public class maximum_alternating_subsequence_sum
    {
        public long MaxAlternatingSum(int[] nums)
        {
            long odd = 0l;
            long even = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                odd = Math.Max(odd, even - nums[i]);
                even = Math.Max(even, odd + nums[i]);
            }

            return even;
        }
    }
}
