using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Diagonal_Traverse
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            var m = matrix.Length;
            if (m == 0)
            {
                return new int[0];
            }

            var n = matrix[0].Length;
            var array = new int[m * n];
            array[0] = matrix[0][0];
            int round = 0, x = 0, y = 0, index = 0;

            while (round < m + n - 1)
            {
                if (round % 2 == 0)
                {
                    y = round < m ? round : m - 1;
                    x = round - y;
                    while (x >= 0 && x < n && y >= 0) array[index++] = matrix[y--][x++];
                }
                else
                {
                    x = round < n ? round : n - 1;
                    y = round - x;
                    while (y >= 0 && y < m && x >= 0) array[index++] = matrix[y++][x--];
                }
                round++;
            }

            return array;
        }
    }
}
