using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Smallest_Range_II
    {
        public int SmallestRangeII(int[] A, int K)
        {
            Array.Sort(A);
            var length = A.Length;
            var min = A[0];
            var max = A[length - 1];
            var res = max - min;
            for (int i = 0; i < length - 1; i++)
            {
                max = Math.Max(max, A[i] + 2 * K);
                min = Math.Min(A[i + 1], A[0] + 2 * K);
                res = Math.Min(res, max - min);
            }

            return res;
        }
    }
}
