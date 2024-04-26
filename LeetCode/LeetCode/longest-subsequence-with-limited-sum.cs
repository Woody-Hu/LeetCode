using System;

namespace LeetCode;

public class longest_subsequence_with_limited_sum
{
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums);
        var prefixSum = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        var result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = BinarySearch(prefixSum, queries[i]) - 1;
        }
        
        return result;
    }
    
    private int BinarySearch(int[] prefixSum, int target)
    {
        int left = 1;
        int right = prefixSum.Length ;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (prefixSum[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return left;
    }
}