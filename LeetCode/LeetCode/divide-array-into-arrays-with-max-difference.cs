using System;

namespace LeetCode;

public class divide_array_into_arrays_with_max_difference
{
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        var n = nums.Length;
        var res = new int[n/3][];
        for (var i = 0; i < n/3; i++)
        {
            res[i] = new int[3];
        }

        for (var i = 2; i < n; i+=3)
        {
            if (nums[i] - nums[i-2] > k)
            {
                return Array.Empty<int[]>();
            }
            
            res[i/3] = new int[]{nums[i-2], nums[i-1], nums[i]};
        }
        
        return res;
        
    }
}