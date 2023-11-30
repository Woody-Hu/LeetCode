using System;
namespace LeetCode
{
	public class check_if_matrix_is_x_matrix
	{
        public bool CheckXMatrix(int[][] grid)
        {
            var n = grid.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || (i + j) == (n - 1))
                    {
                        if (grid[i][j] == 0)
                        {
                            return false;
                        }
                    }
                    else if (grid[i][j] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

