using System;
namespace LeetCode
{
    public class minimum_difference_between_highest_and_lowest_of_k_scores
    {
        public int MinimumDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            var res = int.MaxValue;
            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                res = Math.Min(nums[i + k - 1] - nums[i], res);
            }

            return res;
        }
    }
}
