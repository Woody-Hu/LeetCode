using System;

namespace LeetCode;

public class sum_of_variable_length_subarrays
{
    public int SubarraySum(int[] nums) {
        var n = nums.Length;
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = Math.Max(i - nums[i], 0); j <= i; j++)
            {
                res += nums[j];
            }
        }

        return res;

    }
}