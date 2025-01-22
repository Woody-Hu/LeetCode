using System;
using System.Collections.Generic;

namespace LeetCode;

public class find_the_maximum_sequence_value_of_array
{
    public int MaxValue(int[] nums, int k) {
        var A = FindORs(nums, k);
        Array.Reverse(nums);
        var B = FindORs(nums, k);
        int mx = 0;
        for (int i = k - 1; i < nums.Length - k; i++) {
            foreach (int a in A[i]) {
                foreach (int b in B[nums.Length - i - 2]) {
                    mx = Math.Max(mx, a ^ b);
                }
            }
        }
        return mx;
    }

    public List<HashSet<int>> FindORs(int[] nums, int k) {
        var dp = new List<HashSet<int>>();
        var prev = new List<HashSet<int>>();
        for (int i = 0; i <= k; i++) {
            prev.Add(new HashSet<int>());
        }
        prev[0].Add(0);
        for (int i = 0; i < nums.Length; i++) {
            for (int j = Math.Min(k - 1, i + 1); j >= 0; j--) {
                foreach (int x in prev[j]) {
                    prev[j + 1].Add(x | nums[i]);
                }
            }
            dp.Add(new HashSet<int>(prev[k]));
        }
        return dp;
    }
}