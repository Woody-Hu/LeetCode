
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class RangeAdditionII
    {
        public int MaxCount(int m, int n, int[,] ops)
        {
            int useRowLength = m;
            int useColumnLength = n;

            for (int i = 0; i < ops.GetLength(0); i++)
            {
                useRowLength = Math.Min(useRowLength, ops[i, 0]);
                useColumnLength = Math.Min(useColumnLength, ops[i, 1]);
            }

            return useRowLength * useColumnLength;

        

        }
    }
}