using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_N_Unique_Integers_Sum_up_to_Zero
    {
        public int[] SumZero(int n)
        {
            if (n == 1)
            {
                return new int[] { 0 };
            }

            int[] res;
            int value = 1;
            var i = 0;
            res = new int[n];
            if (n % 2 != 0)
            {
                res[0] = 0;
                i = 1;
            }

            for ( ; i < n; i = i +2)
            {
                res[i] = value;
                res[i + 1] = -value;
                value++;
            }

            return res;
        }
    }
}
