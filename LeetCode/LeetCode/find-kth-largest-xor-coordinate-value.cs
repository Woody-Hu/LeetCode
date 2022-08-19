using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_kth_largest_xor_coordinate_value
    {
        public int KthLargestValue(int[][] matrix, int k)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int[,] pre = new int[m + 1, n + 1];
            var list = new List<int>();
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    pre[i, j] = pre[i - 1, j] ^ pre[i, j - 1] ^ pre[i - 1, j - 1] ^ matrix[i - 1][j - 1];
                    list.Add(pre[i, j]);
                }
            }

            list.Sort(delegate (int num1, int num2) {
                return num2 - num1;
            });
            return list[k - 1];
        }
    }
}
