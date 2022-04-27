using System;
using System.Linq;

namespace LeetCode
{
    public class check_if_an_array_is_consecutive
    {
        public bool IsConsecutive(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            Array.Sort(nums);
            var min = nums[0];
            var max = nums[nums.Length - 1];
            return max - min == nums.Length - 1 && nums.Distinct().Count() == nums.Length;
        }
    }
}
