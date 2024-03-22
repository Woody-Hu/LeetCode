using System;
using System.Collections.Generic;

namespace LeetCode;

public class number_of_distinct_averages
{
    public int DistinctAverages(int[] nums) {
        Array.Sort(nums);
        var set = new HashSet<int>();
        for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
        {
            set.Add(nums[i] + nums[j]);
        }
        
        return set.Count;
    }
}