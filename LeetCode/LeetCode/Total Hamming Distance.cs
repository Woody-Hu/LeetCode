using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Total_Hamming_Distance
    {
        public int TotalHammingDistance(int[] nums)
        {
            var arrayOne = new int[32];
            var arrayZero = new int[32];
            var res = 0;
            foreach (var oneNum in nums)
            {
                var n = oneNum;
                for (int i = 0; i < 32; ++i)
                {
                    if ((n & 1) == 0)
                    {
                        res += arrayZero[i];
                        arrayOne[i]++;
                    }
                    else
                    {
                        res += arrayOne[i];
                        arrayZero[i]++;
                    }
                    n = n >> 1;
                }
            }

            return res;
        }
    }
}
