using System.Collections.Generic;

namespace LeetCode;

public class minimum_number_of_operations_to_make_elements_in_array_distinct
{
    public int MinimumOperations(int[] nums) {
        int ans = 0;
        for (int i = 0; i < nums.Length; i += 3, ans++) {
            if (CheckUnique(nums, i)) {
                return ans;
            }
        }
        return ans;
    }

    private bool CheckUnique(int[] nums, int start) {
        HashSet<int> seen = new HashSet<int>();
        for (int i = start; i < nums.Length; i++) {
            if (seen.Contains(nums[i])) {
                return false;
            }
            seen.Add(nums[i]);
        }
        return true;
    }
}