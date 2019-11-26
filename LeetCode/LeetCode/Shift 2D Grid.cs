using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Shift_2D_Grid
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int sizeN = grid.Length, sizeM = grid[0].Length;
            int index = (sizeM * sizeN - (k % (sizeM * sizeN))) % (sizeM * sizeN);

            var shifted = new List<IList<int>>();
            for (int i = 0; i < sizeN; ++i)
            {
                var row = new List<int>();
                for (int j = 0; j < sizeM; ++j)
                {
                    row.Add(grid[index / sizeM][index % sizeM]);
                    index = (index + 1) % (sizeN * sizeM);
                }
                shifted.Add(row);
            }

            return shifted;
        }
    }
}
