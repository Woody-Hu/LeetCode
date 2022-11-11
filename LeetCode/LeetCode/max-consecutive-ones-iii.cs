using System;
namespace LeetCode
{
    public class max_consecutive_ones_iii
    {
        public int LongestOnes(int[] nums, int k)
        {
            var res = 0;
            var left = 0;
            var leftSum = 0;
            var rightSum = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                rightSum += 1 - nums[r];
                while (leftSum < rightSum - k)
                {
                    leftSum += 1 - nums[left++];
                }

                res = Math.Max(res, r - left + 1);
            }

            return res;
        }
    }
}
