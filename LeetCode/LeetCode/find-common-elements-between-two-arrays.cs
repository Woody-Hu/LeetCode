using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_common_elements_between_two_arrays
	{
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            foreach (var item in nums1)
            {
                set1.Add(item);
            }

            foreach (var item in nums2)
            {
                set2.Add(item);
            }

            var res = new int[2];
            foreach (var item in nums1)
            {
                if (set2.Contains(item))
                {
                    res[0]++;
                }
            }

            foreach (var item in nums2)
            {
                if (set1.Contains(item))
                {
                    res[1]++;
                }
            }

            return res;
        }
    }
}

