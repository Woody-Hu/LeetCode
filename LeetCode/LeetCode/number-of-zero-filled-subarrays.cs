using System;
namespace LeetCode
{
	public class number_of_zero_filled_subarrays
	{
        public long ZeroFilledSubarray(int[] nums)
        {
            var res = 0l;
            var count = 0;
            foreach (var item in nums)
            {
                if (item != 0)
                {
                    count = 0;
                }
                else
                {
                    res += count;
                }
            }

            return res;
        }
    }
}

