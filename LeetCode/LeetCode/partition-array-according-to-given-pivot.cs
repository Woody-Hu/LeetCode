using System;
namespace LeetCode
{
    public class partition_array_according_to_given_pivot
    {
        public int[] PivotArray(int[] nums, int pivot)
        {
            var res = new int[nums.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = pivot;
            }

            var left = 0;
            var right = nums.Length - 1;
            for (int i = 0; i < res.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    res[left] = nums[i];
                    left++;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] > pivot)
                {
                    res[right] = nums[i];
                    right--;
                }
            }

            return res;
        }
    }
}
