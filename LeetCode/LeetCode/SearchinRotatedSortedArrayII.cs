using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchinRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {
            if (null == nums || nums.Length == 0)
            {
                return false;
            }

            return Search(nums, 0, nums.Length - 1, target);
        }

        private bool Search(int[] nums, int startIndex, int endIndex, int target)
        {
            if (startIndex == endIndex)
            {
                return nums[startIndex] == target;
            }

            if ((nums[startIndex] < nums[endIndex]) && (nums[startIndex] > target || nums[endIndex] < target) )
            {
                return false;
            }

            return Search(nums, startIndex, (startIndex + endIndex) / 2, target) ||
                   Search(nums, (startIndex + endIndex) / 2+1, endIndex, target);
        }
    }
}
