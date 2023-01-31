using System;
namespace LeetCode
{
	public class increment_submatrices_by_one
	{
        public int[][] RangeAddQueries(int n, int[][] queries)
        {
            var diff = new int[n + 2, n + 2];
            var res = new int[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new int[n];
            }

            foreach (var item in queries)
            {
                var r1 = item[0];
                var c1 = item[1];
                var r2 = item[2];
                var c2 = item[3];
                ++diff[r1 + 1, c1 + 1];
                --diff[r1 + 1, c2 + 2];
                --diff[r2 + 2, c1 + 1];
                ++diff[r2 + 2, c2 + 2];
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    diff[i, j] += diff[i, j - 1] + diff[i - 1, j] - diff[i - 1, j - 1];
                    res[i -1][j - 1] = diff[i, j];
                }
            }

            return res;
        }
    }
}

