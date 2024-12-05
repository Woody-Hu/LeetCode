using System;

namespace LeetCode;

public class count_elements_with_strictly_smaller_and_greater_elements
{
    public int CountElements(int[] nums) {
        var count = 0;
        Array.Sort(nums);
        var length = nums.Length;
        int minNum = nums[0], maxNum = nums[length - 1];
        for (var i = 0; i < length && nums[i] < maxNum; i++) {
            if (nums[i] > minNum) {
                count++;
            }
        }
        
        return count;
    }
}