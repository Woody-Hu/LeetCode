using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Sort_Integers_by_The_Number_of_1_Bits
    {
        public int[] SortByBits(int[] arr)
        {
            Array.Sort(arr, (n1, n2) =>
            {
                var count1 = GetCount(n1);
                var count2 = GetCount(n2);
                var onesCmp = count1.CompareTo(count2);
                if (onesCmp != 0)
                {
                    return onesCmp;
                }

                return n1.CompareTo(n2);
            });

            return arr;
        }

        private int GetCount(int value)
        {
            var res = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((value & (1 << i)) != 0)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
