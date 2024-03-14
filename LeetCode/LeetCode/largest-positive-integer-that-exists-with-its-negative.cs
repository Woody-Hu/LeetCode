using System;

namespace LeetCode;

public class largest_positive_integer_that_exists_with_its_negative
{
    public int FindMaxK(int[] nums) {
        Array.Sort(nums);
        for (int i = 0,  j = nums.Length - 1 ; i < j; j--)
        {
            while (i < j && nums[i] < -nums[j])
            {
                i++;
            }

            if (nums[i] == -nums[j])
            {
                return nums[j];
            }
        }

        return -1;

    }
}