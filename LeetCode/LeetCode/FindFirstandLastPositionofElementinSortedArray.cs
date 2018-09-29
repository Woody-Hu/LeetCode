using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FindFirstandLastPositionofElementinSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (null == nums||nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }

            var tempStartIndex = InnerMethod(nums, 0, nums.Length - 1, target);

            if (tempStartIndex == nums.Length || nums[tempStartIndex] != target)
            {
                return new int[] { -1, -1 };
            }

            var tempEndIndex = InnerMethod(nums, 0, nums.Length - 1, target+1);

            return new int[] { tempStartIndex, nums[tempEndIndex] == target ? tempEndIndex : tempEndIndex - 1 };
        }

        private int InnerMethod(int[] nums,int low,int high,int target)
        {
            while (low < high)
            {

                int mid = low + (high - low) / 2;

                if (nums[mid] < target)
                {
                    low = mid + 1;

                }
                else
                    high = mid;
            }

            return high;

        }
    }
}
