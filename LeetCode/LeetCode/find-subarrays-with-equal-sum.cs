using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_subarrays_with_equal_sum
	{
        public bool FindSubarrays(int[] nums)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                set.Add(nums[i] + nums[i + 1]);
            }

            return set.Count < nums.Length - 1;
        }
    }
}

