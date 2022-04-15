using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Find_the_Difference_of_Two_Arrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = nums1.ToHashSet();
            var set2 = nums2.ToHashSet();
            var res = new List<IList<int>>() { new List<int>(), new List<int>()};
            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    res[0].Add(item);
                }
            }

            foreach (var item in set2)
            {
                if (!set1.Contains(item))
                {
                    res[1].Add(item);
                }
            }

            return res;
        }
    }
}
