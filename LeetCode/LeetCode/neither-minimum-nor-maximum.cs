using System;
namespace LeetCode
{
	public class neither_minimum_nor_maximum
	{
        public int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length < 3)
            {
                return -1;
            }

            Array.Sort(nums, 0, 3);
            return nums[1];
        }
    }
}

