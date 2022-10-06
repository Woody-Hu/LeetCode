using System;
namespace LeetCode
{
    public class bitwise_xor_of_all_pairings
    {
        public int XorAllNums(int[] nums1, int[] nums2)
        {
            var l1 = nums1.Length;
            var l2 = nums2.Length;
            var r1 = 0;
            var r2 = 0;
            foreach (var item in nums1)
            {
                r1 ^= item;
            }

            foreach (var item in nums2)
            {
                r2 ^= item;
            }

            if (l1 %2 ==0)
            {
                r2 = 0;
            }

            if (l2 % 2 ==0)
            {
                r1 = 0;
            }

            return r1 ^ r2;
        }
    }
}
