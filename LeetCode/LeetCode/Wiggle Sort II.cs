using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Wiggle_Sort_II
    {
        public void WiggleSort(int[] nums)
        {
            var array = new int[nums.Length];
            Array.Copy(nums, array, nums.Length);
            Array.Sort(array);
            for (int i = 0, j = 0, n = nums.Length, k = (n - 1) / 2; i < n;)
            {
                nums[i++] = array[k + j];
                if (i < n)
                {
                    nums[i++] = array[n - 1 + (j--)];
                }
            }

        }
    }
}
