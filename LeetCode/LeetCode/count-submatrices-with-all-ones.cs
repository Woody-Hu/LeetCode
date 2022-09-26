using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class count_submatrices_with_all_ones
    {
        public int NumSubmat(int[][] mat)
        {
            int n = mat.Length;
            int m = mat[0].Length;
            var row = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (j == 0)
                    {
                        row[i, j] = mat[i][j];
                    }
                    else if (mat[i][j] != 0)
                    {
                        row[i, j] = row[i, j - 1] + 1;
                    }
                    else
                    {
                        row[i, j] = 0;
                    }
                }
            }

            var res = 0;
            for (int j = 0; j < m; j++)
            {
                var i = 0;
                var stack = new Stack<int[]>();
                var sum = 0;
                while (i <= n -1)
                {
                    var height = 1;
                    while (stack.Any() && stack.Peek()[0] > row[i, j])
                    {
                        sum -= stack.Peek()[1] * (stack.Peek()[0] - row[i, j]);
                        height += stack.Peek()[1];
                        stack.Pop();
                    }

                    sum += row[i, j];
                    res += sum;
                    stack.Push(new int[] { row[i, j], height });
                    i++;
                }
            }

            return res;
        }
    }
}
