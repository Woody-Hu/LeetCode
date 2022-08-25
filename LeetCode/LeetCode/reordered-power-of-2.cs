using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class reordered_power_of_2
    {
        public bool ReorderedPowerOf2(int n)
        {
            char[] nums = n.ToString().ToCharArray();
            Array.Sort(nums);
            var vis = new bool[nums.Length];
            return Backtrack(nums, 0, 0, ref vis);
        }

        private bool Backtrack(char[] nums, int idx, int num, ref bool[] vis)
        {
            if (idx == nums.Length)
            {
                return IsPowerOfTwo(num);
            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if ((num == 0 && nums[i] == '0') || vis[i] || (i > 0 && !vis[i - 1] && nums[i] == nums[i - 1]))
                {
                    continue;
                }
                vis[i] = true;
                if (Backtrack(nums, idx + 1, num * 10 + nums[i] - '0', ref vis))
                {
                    return true;
                }

                vis[i] = false;
            }
            return false;
        }

        private bool IsPowerOfTwo(int n)
        {
            return (n & (n - 1)) == 0;
        }
    }
}
