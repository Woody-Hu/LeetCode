using System;
namespace LeetCode
{
    public class Concatenation_of_Array
    {
        public int[] GetConcatenation(int[] nums)
        {
            var res = new int[2 * nums.Length];
            Array.Copy(nums, res, nums.Length);
            Array.Copy(nums, 0,  res, nums.Length, nums.Length);
            return res;
        }
    }
}
