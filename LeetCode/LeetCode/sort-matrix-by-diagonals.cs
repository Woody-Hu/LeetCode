using System;
using System.Collections.Generic;

namespace LeetCode;

public class sort_matrix_by_diagonals
{
    int n;

    public int[][] SortMatrix(int[][] grid)
    {
        n = grid[0].Length;
        for (int i = 0; i < n; i++)
        {
            SortDiagonal(grid, i, 0, true);
        }

        for (int j = 1; j < n; j++)
        {
            SortDiagonal(grid, 0, j, false);
        }

        return grid;
    }

    public void SortDiagonal(int[][] grid, int startRow, int startCol, bool reverse)
    {
        int length = Math.Min(n - startRow, n - startCol);
        for (int i = 1; i < length; i++)
        {
            int num = grid[startRow + i][startCol + i];
            int insertIndex = i;
            for (int j = i - 1; j >= 0 && ShouldChangeOrder(grid[startRow + j][startCol + j], num, reverse); j--)
            {
                grid[startRow + j + 1][startCol + j + 1] = grid[startRow + j][startCol + j];
                insertIndex = j;
            }

            if (insertIndex != i)
            {
                grid[startRow + insertIndex][startCol + insertIndex] = num;
            }
        }
    }

    public bool ShouldChangeOrder(int prev, int curr, bool reverse)
    {
        return reverse ? prev < curr : prev > curr;
    }
}