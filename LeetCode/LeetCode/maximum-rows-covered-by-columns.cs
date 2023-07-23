using System;
namespace LeetCode
{
	public class maximum_rows_covered_by_columns
	{
        public int MaximumRows(int[][] matrix, int numSelect)
        {
            var n = matrix[0].Length;
            var dp = new int[1 << n];
            foreach (var item in matrix)
            {
                var mask = 0;
                for (int i = 0; i < n; i++)
                {
                    mask = mask << 1 | item[i];
                }

                for (int i = 0; i < 1 << n; i++)
                {
                    if ((i & mask) == mask)
                    {
                        dp[i]++;
                    }
                }
            }

            var res = 0;
            for (int i = 0; i < 1 << n; i++)
            {
                var cnt = 0;
                for (int j = 0; j < n; j++)
                {
                    if ((i >> j & 1) == 1)
                    {
                        cnt++;
                    }
                }

                if (cnt == numSelect)
                {
                    res = Math.Max(res, dp[i]);
                }
            }

            return res;
        }
    }
}

