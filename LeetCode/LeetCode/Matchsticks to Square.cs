using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Matchsticks_to_Square
    {
        public bool Makesquare(int[] nums)
        {
            if (nums.Length == 0)
            {
                return false;
            }

            var sum = nums.Sum();
            if (sum % 4 != 0)
            {
                return false;
            }

            var length = sum / 4;
            Array.Sort(nums);
            var used = new bool[nums.Length];
            return Makesquare(nums, used, 0, length, 0, 4);
        }

        private bool Makesquare(int[] nums, bool[] used, int curSum, int target, int start, int k)
        {
            if (k == 1) return true;
            if (curSum == target)
            {
                return Makesquare(nums, used, 0, target, 0, k - 1);
            }
            for (int i = start; i < nums.Length; i++)
            {
                if (used[i]) continue;
                used[i] = true;
                if (Makesquare(nums, used, curSum + nums[i], target, i + 1, k))
                {
                    return true;
                }
                used[i] = false;
            }
            return false;
        }
    }
}
