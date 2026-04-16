using System.Collections.Generic;

namespace LeetCode;

public class minimum_operations_to_reach_target_array
{
    public int MinOperations(int[] nums, int[] target) {
        ISet<int> diffSet = new HashSet<int>();
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            if (nums[i] != target[i]) {
                diffSet.Add(nums[i]);
            }
        }
        return diffSet.Count;
    }
}