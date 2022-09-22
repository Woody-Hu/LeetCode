using System;
namespace LeetCode
{
    public class number_of_enclaves
    {
        public int NumEnclaves(int[][] grid)
        {
            int[][] dirs = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
            var m = grid.Length;
            var n = grid[0].Length;
            var visited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            for (int i = 0; i < m; i++)
            {
                DFS(grid, i, 0, m, n, dirs, visited);
                DFS(grid, i, n - 1, m, n, dirs, visited);
            }

            for (int j = 1; j < n - 1; j++)
            {
                DFS(grid, 0, j, m, n, dirs, visited);
                DFS(grid, m - 1, j, m, n, dirs, visited);
            }

            var res = 0;
            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    if (grid[i][j] == 1 && !visited[i][j])
                    {
                        res++;
                    }
                }
            }

            return res;
        }

        private void DFS(int[][] grid, int row, int col, int m, int n, int[][] dirs, bool[][] visited)
        {
            if (row < 0 || row >= m || col < 0 || col >= n || grid[row][col] == 0 || visited[row][col])
            {
                return;
            }
            visited[row][col] = true;

            foreach (int[] dir in dirs)
            {
                DFS(grid, row + dir[0], col + dir[1], m, n, dirs, visited);
            }
        }
    }
}
