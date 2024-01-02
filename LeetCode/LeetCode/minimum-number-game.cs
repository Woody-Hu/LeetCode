using System;
namespace LeetCode
{
	public class minimum_number_game
	{
        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i+=2)
            {
                var temp = nums[i - 1];
                nums[i - 1] = nums[i];
                nums[i] = temp;
            }

            return nums;
        }
    }
}

