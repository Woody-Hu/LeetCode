using System.Collections.Generic;

namespace LeetCode;

public class number_of_submatrices_that_sum_to_target
{
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        var ans = 0;
        int m = matrix.Length, n = matrix[0].Length;
        for (int i = 0; i < m; ++i) { 
            var sum = new int[n];
            for (int j = i; j < m; ++j) 
            { 
                for (int c = 0; c < n; ++c) 
                {
                    sum[c] += matrix[j][c]; 
                }
                
                ans += SubarraySum(sum, target);
            }
        }
        
        return ans;
    }

    private int SubarraySum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        dic.Add(0, 1);
        var count = 0;
        var pre = 0;
        foreach (var num in nums)
        {
            pre += num;
            if (dic.ContainsKey(pre - target))
            {
                count += dic[pre - target];
            }
            if (dic.ContainsKey(pre))
            {
                dic[pre]++;
            }
            else
            {
                dic.Add(pre, 1);
            }
        }

        return count;
    }

}