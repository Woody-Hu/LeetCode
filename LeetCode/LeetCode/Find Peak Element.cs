using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Peak_Element
    {
        public int FindPeakElement(int[] nums)
        {
            var length = nums.Length;
            if (0 == length || 1 == length)
            {
                return 0;
            }

            var leftIndex = 0;
            var rightIndex = length - 1;

            while (leftIndex < rightIndex)
            {
                var mid = (leftIndex + rightIndex) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    leftIndex = mid + 1;
                }
                else
                {
                    rightIndex = mid;
                }
            }

            return leftIndex;

        }
    }
}
