using System;
namespace LeetCode
{
	public class divide_an_array_into_subarrays_with_minimum_cost_i
	{
        public int MinimumCost(int[] nums)
        {
            var first = nums[0];
            var subArray = new int[nums.Length - 1];
            Array.Copy(nums, 1, subArray, 0, nums.Length - 1);
            Array.Sort(subArray);
            return first + subArray[0] + subArray[1];
        }
    }
}

