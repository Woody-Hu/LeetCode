using System;
namespace LeetCode
{
	public class minimum_operations_to_exceed_threshold_value_i
	{
        public int MinOperations(int[] nums, int k)
        {
            var res = 0;
            foreach (var item in nums)
            {
                if (item < k)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

