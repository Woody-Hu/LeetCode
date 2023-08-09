using System;
namespace LeetCode
{
	public class maximum_absolute_sum_of_any_subarray
	{
        public int MaxAbsoluteSum(int[] nums)
        {
            var s = 0;
            var max = 0;
            var min = 0;
            foreach (var item in nums)
            {
                s += item;
                if (s > max)
                {
                    max = s;
                }
                else if (s < min)
                {
                    min = s;
                }
            }

            return max - min;
        }
    }
}

