using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Arithmetic_Slices
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            var lastSpan = A[0] - A[1];
            var count = 1;
            var res = 0;
            for (int i = 2; i < A.Length; i++)
            {
                var span = A[i - 1] - A[i];
                if (span == lastSpan)
                {
                    count++;
                }
                else
                {
                    while (count > 1)
                    {
                        count--;
                        res += count;
                    }
                    lastSpan = span;
                }
            }

            while (count > 1)
            {
                count--;
                res += count;
            }

            return res;
        }
    }
}
