using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_the_Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {
            if (nums.Length > 1)
            {
                var slow = nums[0];
                var fast = nums[nums[0]];
                while (slow != fast)
                {
                    slow = nums[slow];
                    fast = nums[nums[fast]];
                }

                fast = 0;
                while (fast != slow)
                {
                    fast = nums[fast];
                    slow = nums[slow];
                }
                return slow;
            }
            return -1;
        }
    }
}
