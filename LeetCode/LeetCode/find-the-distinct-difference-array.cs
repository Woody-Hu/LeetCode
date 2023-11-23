using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_the_distinct_difference_array
	{
        public int[] DistinctDifferenceArray(int[] nums)
        {
            var n = nums.Length;
            var suf = new int[n + 1];
            var set = new HashSet<int>();
            for (int i = n - 1; i > 0; i--)
            {
                set.Add(nums[i]);
                suf[i] = set.Count;
            }

            set.Clear();
            var res = new int[n];
            for (int i = 0; i < n; i++)
            {
                set.Add(nums[i]);
                res[i] = set.Count - suf[i + 1];
            }

            return res;
        }
    }
}

