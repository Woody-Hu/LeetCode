using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Counting_Bits
    {
        public int[] CountBits(int num)
        {
            var array = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                array[i] = array[i >> 1] + (i & 1);
            }

            return array;
        }
    }
}
