using System;

namespace LeetCode;

public class minimum_average_of_smallest_and_largest_elements
{
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);
        var n = nums.Length;
        var res = int.MaxValue;
        for (var i = 0; i < n / 2; i++)
        {
            res = Math.Min(res, nums[i] + nums[n - i - 1]);
        }
        
        return res / 2.0;
    }
}