using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Convert_Integer_to_the_Sum_of_Two_No_Zero_Integers
    {
        public int[] GetNoZeroIntegers(int n)
        {
            if (n < 10)
                return new[] { 1, n - 1 };

            int x = n;
            int i = 0;
            int a = 0;
            while (n >= 10)
            {
                int r = n % 10;
                int d = (r == 1) ? 2 : 1;
                int pow10 = 1;
                int j = i;
                while (j-- > 0)
                    pow10 *= 10;
                a += d * pow10;
                i += 1;
                n -= d;
                n /= 10;
            }

            return new[] { a, x - a };
        }
    }
}
