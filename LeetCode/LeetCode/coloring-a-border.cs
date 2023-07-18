using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class coloring_a_border
	{
        public int[][] ColorBorder(int[][] grid, int row, int col, int color)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var visited = new bool[m, n];
            var borders = new List<int[]>();
            var originalColor = grid[row][col];
            int[][] direc = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            var q = new Queue<int[]>();
            visited[row, col] = true;
            q.Enqueue(new int[] { row, col });
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                int x = node[0], y = node[1];
                bool isBorder = false;
                for (int i = 0; i < 4; i++)
                {
                    int nx = direc[i][0] + x, ny = direc[i][1] + y;
                    if (!(nx >= 0 && nx < m && ny >= 0 && ny < n && grid[nx][ny] == originalColor))
                    {
                        isBorder = true;
                    }
                    else if (!visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        q.Enqueue(new int[] { nx, ny });
                    }
                }
                if (isBorder)
                {
                    borders.Add(new int[] { x, y });
                }
            }
            for (int i = 0; i < borders.Count; i++)
            {
                int x = borders[i][0], y = borders[i][1];
                grid[x][y] = color;
            }

            return grid;
        }
    }
}

