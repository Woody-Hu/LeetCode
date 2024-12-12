using System;

namespace LeetCode;

public class check_if_array_is_good
{
    public bool IsGood(int[] nums) {
        var n = nums.Length - 1;
        Array.Sort(nums);
        if (nums[n] != n || nums[n - 1] != n) {
            return false;
        }
        for (var i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return false;
            }
        }
        
        return true;
        
    }
}