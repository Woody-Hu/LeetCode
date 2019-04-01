using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Binary_Prefix_Divisible_By_5
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            var value = A[0];
            var list = new List<bool>
            {
                value == 0
            };

            for (int i = 1; i < A.Length; i++)
            {
                value = value << 1;
                value += A[i];
                value = value % 5;
                if (value == 0)
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }

            return list;
        }
    }
}
