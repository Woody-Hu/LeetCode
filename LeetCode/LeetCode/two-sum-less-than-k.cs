using System;
namespace LeetCode
{
    public class two_sum_less_than_k
    {
        public int TwoSumLessThanK(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return -1;
            }

            Array.Sort(nums);
            if (nums[0] + nums[1] > k)
            {
                return -1;
            }

            var res = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var current = nums[i] + nums[j];
                    if (current > res && current < k)
                    {
                        res = current;
                    }
                }

            }

            return res;
        }
    }
}
