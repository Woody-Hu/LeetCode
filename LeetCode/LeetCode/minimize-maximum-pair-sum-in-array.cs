using System;
namespace LeetCode
{
    public class minimize_maximum_pair_sum_in_array
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            var res = 0;
            for (int i = 0; i < nums.Length / 2; ++i)
            {
                res = Math.Max(res, nums[i] + nums[nums.Length - 1 - i]);
            }

            return res;
        }
    }
}
