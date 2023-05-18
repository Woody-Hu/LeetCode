using System;
namespace LeetCode
{
	public class equal_sum_arrays_with_minimum_number_of_operations
	{
        public int MinOperations(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var m = nums2.Length;
            if (6*n < m || 6 * m < n)
            {
                return -1;
            }

            var a1 = new int[7];
            var a2 = new int[7];
            var diff = 0;
            foreach (var item in nums1)
            {
                a1[item]++;
                diff += item;
            }

            foreach (var item in nums2)
            {
                a2[item]++;
                diff -= item;
            }

            if (diff == 0)
            {
                return 0;
            }

            if (diff > 0)
            {
                return Calculate(a2, a1, diff);
            }

            return Calculate(a1, a2, -diff);
        }

        private int Calculate(int[] h1, int[] h2, int diff)
        {
            var c = new int[7];
            for (int i = 1; i < 7; i++)
            {
                c[6 - i] += h1[i];
                c[i - 1] += h2[i];
            }

            var res = 0;
            for (int i = 5; i >0 && diff>0; i--)
            {
                var t = Math.Min((diff + i - 1) / i, c[i]);
                res += t;
                diff -= t * i;
            }

            return res;
        }
    }
}

