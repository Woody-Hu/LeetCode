using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int tempStartIndex = 0;

            int tempEndIndex = nums.Length - 1;

            while (tempStartIndex <= tempEndIndex)
            {
                var tempMidIndex = (tempStartIndex + tempEndIndex) / 2;

                if (nums[tempMidIndex] < target )
                {
                    tempStartIndex = tempMidIndex + 1;
                }
                else if (nums[tempMidIndex] > target)
                {
                    tempEndIndex = tempMidIndex-1;
                }
                else
                {
                    return tempMidIndex;
                }

                
            }
            return -1;
        }
    }
}
