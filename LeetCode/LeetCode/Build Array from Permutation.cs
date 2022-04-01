using System;
namespace LeetCode
{
    public class Build_Array_from_Permutation
    {
        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                nums[i] = nums[i] + n * (nums[nums[i]] % n);
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = nums[i] / n;
            }

            return nums;
        }
    }
}
