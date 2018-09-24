using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SmallestRangeI
    {
        public int SmallestRangeIMehtod(int[] A, int K)
        {
            Array.Sort(A);

            var tempMinValue = A[0];
            var tempMaxValue = A[A.Length - 1];

            if (tempMaxValue-tempMinValue <= 2*K)
            {
                return 0;
            }

            return tempMaxValue - tempMinValue - 2 * K;

        }
    }
}
