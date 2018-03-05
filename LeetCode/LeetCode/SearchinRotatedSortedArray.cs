using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int start = 0;

            int end = nums.Length;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[start] <= nums[mid])
                {
                    if (target < nums[mid] && target >= nums[start])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }

                if (nums[mid] <= nums[end])
                {
                    if (target > nums[mid] && target <= nums[end])
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }

            return -1;
        }
    }
}
