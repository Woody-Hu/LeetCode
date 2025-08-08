using System;

namespace LeetCode;

public class longest_strictly_increasing_or_strictly_decreasing_subarray
{
    public int LongestMonotonicSubarray(int[] nums)
    {
        var res = 1;
        var i = 0;
        var n = nums.Length;
        while (i < n - 1)
        {
            if (nums[i + 1] == nums[i])
            {
                i++;
                continue;
            }

            var i0 = i;
            var pattern = nums[i + 1] > nums[i];
            i += 2;
            while (i < n && nums[i] != nums[i - 1] && (nums[i] > nums[i - 1]) == pattern )
            {
                i++;
            }

            res = Math.Max(res, i - i0);
            i--;
            
        }

        return res;

    }
}