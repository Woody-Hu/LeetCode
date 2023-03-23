using System;
namespace LeetCode
{
	public class maximize_greatness_of_an_array
	{
        public int MaximizeGreatness(int[] nums)
        {
            Array.Sort(nums);
            var i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    i++;
                }
            }

            return i;
        }
    }
}

