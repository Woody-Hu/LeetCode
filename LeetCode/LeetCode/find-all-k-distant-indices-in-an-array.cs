using System;
using System.Collections.Generic;

namespace LeetCode;

public class find_all_k_distant_indices_in_an_array
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var res = new List<int>();
        var r = 0;
        var n = nums.Length;
        for (int j = 0; j < n; j++)
        {
            if (nums[j] == key)
            {
                var l = Math.Max(r, j - k);
                r = Math.Min(n - 1, j + k)+1;
                for (int i = l; i < r; i++)
                {
                    res.Add(i);
                }
            }
            
        }

        return res;

    }
}