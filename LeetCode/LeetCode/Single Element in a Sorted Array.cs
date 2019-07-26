using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Single_Element_in_a_Sorted_Array
    {
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (mid % 2 == 1)
                {
                    if (nums[mid] == nums[mid - 1])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
                else
                {
                    if (nums[mid] == nums[mid + 1])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
            }
            return nums[lo];
        }
    }
}
