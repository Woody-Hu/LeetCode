using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LeetCode
{
    class Ugly_Number_II
    {
        public int NthUglyNumber(int n)
        {
            if (n <= 0)
            {
                return -1;
            }

            var array = new int[n];
            array[0] = 1;
            var pointer2 = 0;
            var pointer3 = 0;
            var pointer5 = 0;
            for (int i = 1; i < n; i++)
            {
                array[i] = Math.Min(Math.Min(2 * array[pointer2], 3 * array[pointer3]), 5 * array[pointer5]);

                if (array[i] == 2* array[pointer2])
                {
                    pointer2++;
                }
                if (array[i] == 3 * array[pointer3])
                {
                    pointer3++;
                }
                if (array[i] == 5 * array[pointer5])
                {
                    pointer5++;
                }
            }

            return array[n - 1];
        }
    }
}
