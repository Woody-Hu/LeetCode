using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniquePaths
    {
        public int UniquePathsMethod(int m, int n)
        {
            int[,] paths = new int[n+1,m+1];

            paths[1, 0] = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    paths[i, j] = paths[i - 1, j] + paths[i, j - 1];
                }
            }

            return paths[n, m];
        }
    }
}
