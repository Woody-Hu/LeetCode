using System;
namespace LeetCode
{
    public class wiggle_sort
    {
        public void WiggleSort(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length - 1; i = i + 2)
            {
                var value1 = nums[i];
                var value2 = nums[i + 1];
                nums[i + 1] = value1;
                nums[i] = value2;
            }
        }
    }
}
