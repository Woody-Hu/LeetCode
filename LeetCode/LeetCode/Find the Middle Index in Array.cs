using System;
namespace LeetCode
{
    public class Find_the_Middle_Index_in_Array
    {
        public int FindMiddleIndex(int[] nums)
        {
            int totalSum = 0, leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
                totalSum += nums[i];
            for (int i = 0; i < nums.Length; leftSum += nums[i++])
                if (leftSum * 2 == totalSum - nums[i])
                    return i;
            return -1;
        }
    }
}
