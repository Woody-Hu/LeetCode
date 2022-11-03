using System;
namespace LeetCode
{
    public class maximum_distance_between_a_pair_of_values
    {
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            var res = 0;
            var n1 = nums1.Length;
            var n2 = nums2.Length;
            var i = 0;
            for (int j = 0; j < n2; j++)
            {
                while (i < n1 && nums1[i] > nums2[j])
                {
                    i++;
                }

                if (i < n1)
                {
                    res = Math.Max(res, j - i);
                }
            }

            return res;

        }
    }
}

