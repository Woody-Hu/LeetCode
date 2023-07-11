using System;
namespace LeetCode
{
	public class minimum_difference_between_largest_and_smallest_value_in_three_moves
	{
        public int MinDifference(int[] nums)
        {
            if (nums.Length <= 4)
            {
                return 0;
            }

            var n = nums.Length;
            Array.Sort(nums);
            var res = int.MaxValue;
            for (int i = 0; i < 4; i++)
            {
                res = Math.Min(res, nums[n - 4 + i] - nums[i]);
            }

            return res;
        }
    }
}

