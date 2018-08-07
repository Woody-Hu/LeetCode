using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            Array.Sort(nums);

            return nums[0];
        }
    }
}
