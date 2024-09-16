using System;

namespace LeetCode;

public class maximum_xor_score_subarray_queries
{
    public int[] MaximumSubarrayXor(int[] nums, int[][] queries) {
        var n = nums.Length;
        var max = new int[n,n];
        for (int i = n - 1; i >= 0; i--)
        {
            max[i, i] = nums[i];
            for (int j = i + 1; j < n; j++)
            {
                nums[j] ^= nums[j - 1];
                max[i, j] = Math.Max(Math.Max(max[i+1,j], max[i, j - 1]), nums[j]);
            }
        }
        
        var res = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            res[i] = max[queries[i][0], queries[i][1]];
        }
        
        return res;


    }
}