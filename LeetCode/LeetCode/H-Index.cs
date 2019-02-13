using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class H_Index
    {
        public int HIndex(int[] citations)
        {
            var length = citations.Length;
            var buckets = new int[length + 1];
            foreach (var value in citations)
            {
                if (value> length)
                {
                    buckets[length]++;
                }
                else
                {
                    buckets[value]++;
                }
            }

            var sumCount = 0;

            for (int i = length; i >= 0; i--)
            {
                sumCount += buckets[i];

                if (sumCount >= i)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
