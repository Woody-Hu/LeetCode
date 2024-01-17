using System;
namespace LeetCode
{
	public class maximum_count_of_positive_integer_and_negative_integer
	{
        public int MaximumCount(int[] nums)
        {
            var count1 = 0;
            var count2 = 0;
            foreach (var item in nums)
            {
                if (item > 0)
                {
                    count1++;
                }
                else if (item < 0)
                {
                    count2++;
                }
            }

            return Math.Max(count1, count2);
        }
    }
}

