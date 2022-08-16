using System;
namespace LeetCode
{
    public class count_sub_islands
    {
        public int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            var row = grid1.Length;
            var col = grid1[0].Length;
            var res = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid1[i][j] == 1 && grid2[i][j] == 1)
                    {
                        if (Visit(grid1, grid2, i, j))
                        {
                            res++;
                        }
                    }
                }
            }

            return res;
        }

        private bool Visit(int[][] grid1, int[][] grid2, int x, int y)
        {
            if (x < 0 || y < 0 || x >= grid1.Length || y >= grid2[0].Length)
            {
                return true;
            }

            if (grid1[x][y] == 0 && grid2[x][y] == 1)
            {
                return false;
            }

            if (grid2[x][y] == 0)
            {
                return true;
            }

            grid1[x][y] = 0;
            grid2[x][y] = 0;
            var upRes = Visit(grid1, grid2, x + 1, y);
            var downRes = Visit(grid1, grid2, x - 1, y);
            var leftRes = Visit(grid1, grid2, x, y - 1);
            var rightRes = Visit(grid1, grid2, x, y + 1);
            return upRes && downRes && leftRes && rightRes;
        }
    }

}
