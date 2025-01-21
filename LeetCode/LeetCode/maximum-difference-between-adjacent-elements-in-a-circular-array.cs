using System;

namespace LeetCode;

public class maximum_difference_between_adjacent_elements_in_a_circular_array
{
    public int MaxAdjacentDistance(int[] nums)
    {
        var n = nums.Length;
        var res = 0;
        res = Math.Max(res, Math.Abs(nums[0] - nums[n - 1]));
        for (int i = 1; i < n; i++)
        {
            res = Math.Max(res, Math.Abs(nums[i] - nums[i - 1]));
        }
        
        return res;

    }
}