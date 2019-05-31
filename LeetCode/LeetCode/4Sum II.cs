using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _4Sum_II
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var dict = new Dictionary<int, int>();
            var count = 0;

            foreach (var a in A)
            {
                foreach (var b in B)
                {
                    var sum = a + b;
                    dict[sum] = dict.GetValueOrDefault(sum) + 1;
                }
            }

            foreach (var c in C)
            {
                foreach (var d in D)
                {
                    var sum = c + d;
                    count += dict.GetValueOrDefault(-sum);
                }
            }

            return count;
        }
    }
}
