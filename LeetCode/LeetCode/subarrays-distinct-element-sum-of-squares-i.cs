using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class subarrays_distinct_element_sum_of_squares_i
	{
        public int SumCounts(IList<int> nums)
        {
            int mod = 1000000007;
            long sum = 0l;
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                set.Clear();
                set.Add(nums[i]);
                for (int j = i; j < nums.Count; j++)
                {
                    set.Add(nums[j]);
                    sum += set.Count * set.Count;
                    sum %= mod;
                }
            }

            return (int)sum;
        }
    }
}

