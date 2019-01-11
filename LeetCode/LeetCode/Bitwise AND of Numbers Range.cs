using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Bitwise_AND_of_Numbers_Range
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            if (m == 0)
            {
                return 0;
            }

            var count = 1;

            while (m != n)
            {
                m >>= 1;
                n >>= 1;

                count <<= 1;
            }

            return m * count;
        }
    }
}
