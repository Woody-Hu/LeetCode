using System;
namespace LeetCode
{
    public class maximum_product_difference_between_two_pairs
    {
        public int MaxProductDifference(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            return (nums[n - 1] * nums[n - 2]) - (nums[1] * nums[0]);
        }
    }
}
