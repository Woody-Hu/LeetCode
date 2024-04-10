using System;

namespace LeetCode;

public class minimum_sum_of_mountain_triplets_i
{
    public int MinimumSum(int[] nums)
    {
        var n = nums.Length;
        var res = 1000;
        var min = 1000;
        var leftMinValues = new int[n];
        for (var i = 1; i < n; i++)
        {
            leftMinValues[i] = min = Math.Min(nums[i - 1], min);
        }
        
        var right = nums[n - 1];
        for (var i = n - 2; i > 0; i--)
        {
            if (leftMinValues[i] < nums[i] && nums[i] > right)
            {
                res = Math.Min(res, nums[i] + leftMinValues[i] + right);
            }
            
            right = Math.Min(right, nums[i]);
        }
        
        return res == 1000 ? -1 : res;
    }
}