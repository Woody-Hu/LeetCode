using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Matrix_Cells_in_Distance_Order
    {
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            var counter = new int[R + C + 1];
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    var dist = Math.Abs(i - r0) + Math.Abs(j - c0);
                    counter[dist]++;
                }
            }

            for (int i = 1; i < counter.Length; i++)
            {
                counter[i] += counter[i - 1];
            }

            var res = new int[R * C][];
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    var dist = Math.Abs(i - r0) + Math.Abs(j - c0);
                    res[--counter[dist]]= new int[] {i,j};
                }
            }

            return res;
        }
    }
}
