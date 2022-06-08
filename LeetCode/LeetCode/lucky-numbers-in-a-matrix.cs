using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class lucky_numbers_in_a_matrix
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var res = new List<int>();
            var n = matrix.Length;
            var m = matrix[0].Length;
            int rowMax = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                int curMin = matrix[i][0];
                int c = 0;
                for (int j = 1; j < m; j++)
                {
                    if (curMin > matrix[i][j])
                    {
                        curMin = matrix[i][j];
                        c = j;
                    }
                }
                if (rowMax < curMin)
                {
                    rowMax = curMin;
                    k = c;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (rowMax < matrix[i][k])
                {
                    return res;
                }
            }

            res.Add(rowMax);
            return res;
        }
    }
}
