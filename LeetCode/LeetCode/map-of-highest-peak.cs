using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class map_of_highest_peak
    {
        public int[][] HighestPeak(int[][] isWater)
        {
            var directions = new int[][] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 }};
            int m = isWater.Length, n = isWater[0].Length;
            int[][] ans = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                ans[i] = new int[n];
                Array.Fill(ans[i], -1); 
            }

            var queue = new Queue<(int, int)>();
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (isWater[i][j] == 1)
                    {
                        ans[i][j] = 0;
                        queue.Enqueue((i, j)); 
                    }
                }
            }

            while (queue.Any())
            {
                var current = queue.Dequeue();
                foreach (var item in directions)
                {
                    var x = current.Item1 + item[0];
                    var y = current.Item2 + item[1];
                    if (0 <= x && x < m && 0 <= y && y < n && ans[x][y] == -1)
                    {
                        ans[x][y] = ans[current.Item1][current.Item2] + 1;
                        queue.Enqueue((x, y));
                    }
                }
            }

            return ans;
        }
    }
}
