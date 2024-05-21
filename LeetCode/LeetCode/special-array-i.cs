using System;

namespace LeetCode;

public class special_array_i
{
    public bool IsArraySpecial(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] % 2 == nums[i] % 2)
            {
                return false;
            }
        }

        return true;
    }
}