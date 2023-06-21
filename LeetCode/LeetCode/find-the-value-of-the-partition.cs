using System;
namespace LeetCode
{
	public class find_the_value_of_the_partition
	{
        public int FindValueOfPartition(int[] nums)
        {
            Array.Sort(nums);
            var res = int.MaxValue;
            for (int i = 1; i < nums.Length; i++)
            {
                var diff = nums[i] - nums[i - 1];
                res = Math.Min(res, diff);
            }

            return res;
        }
    }
}

