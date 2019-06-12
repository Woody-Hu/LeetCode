using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Moves_to_Equal_Array_Elements_II
    {
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            var mid = nums[nums.Length / 2];
            var res = 0;

            foreach (var oneValue in nums)
            {
                res += Math.Abs(oneValue - mid);
            }

            return res;
        }
    }
}
