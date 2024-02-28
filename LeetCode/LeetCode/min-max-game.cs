using System;
namespace LeetCode
{
	public class min_max_game
	{
        public int MinMaxGame(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
            {
                return nums[0];
            }

            var newNums = new int[n / 2];
            for (int i = 0; i < newNums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newNums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                }
                else
                {
                    newNums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                }
            }

            return MinMaxGame(newNums);
        }
    }
}

