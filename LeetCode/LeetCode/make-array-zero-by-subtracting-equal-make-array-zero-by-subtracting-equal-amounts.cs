using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class make_array_zero_by_subtracting_equal_make_array_zero_by_subtracting_equal_amounts
	{
        public int MinimumOperations(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (item > 0)
                {
                    set.Add(item);
                }
            }

            return set.Count;
        }
    }
}

