using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniqueBinarySearchTrees
    {
        public int NumTrees(int n)
        {
            int[] values = new int[n+1];
            values[0] = 1;
            values[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    values[i] += values[j-1] * values[i - j];
                }
            }

            return values[n];
        }
    }
}
