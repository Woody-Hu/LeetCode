using System;
namespace LeetCode
{
    public class count_servers_that_communicate
    {
        public int CountServers(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var rows = new int[m];
            var columns = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        rows[i]++;
                        columns[j]++;
                    }
                }
            }

            var res = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1 && (rows[i] > 1 || columns[j] > 1 ))
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
