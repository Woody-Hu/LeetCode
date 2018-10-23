using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int useMax = nums[0];
            int useLength = nums.Length;

            for (int i = 1; i < useLength; i++)
            {
                if (useMax < i)
                {
                    return false;
                }

                useMax = Math.Max(nums[i] + i, useMax);
            }

            return true;
        }
    }
}
