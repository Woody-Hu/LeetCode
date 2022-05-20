using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class pacific_atlantic_water_flow
    {
        private IList<(int, int)> _directions = new List<(int, int)>() { (1, 0), (0, 1), (-1, 0), (0, -1) };

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var n = heights.Length;
            var m = heights[0].Length;
            var a = new bool[n, m];
            var b = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                Visit(i, 0, heights, a);
            }
            for (int j = 0; j < m; j++)
            {
                Visit(0, j, heights, a);
            }
            for (int i = 0; i < n; i++)
            {
                Visit(i, m - 1, heights, b);
            }
            for (int j = 0; j < m - 1; j++)
            {
                Visit(n - 1, j, heights, b);
            }

            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] && b[i, j])
                    {
                        IList<int> cell = new List<int>();
                        cell.Add(i);
                        cell.Add(j);
                        result.Add(cell);
                    }
                }
            }
            return result;

        }

        private void Visit(int row, int column, int[][] heights, bool[,] visted)
        {
            if (visted[row, column])
            {
                return;
            }

            visted[row, column] = true;
            var maxRow = visted.GetLength(0);
            var maxColumn = visted.GetLength(1);
            foreach (var item in _directions)
            {
                var newRow = row + item.Item1;
                var newColumn = column + item.Item2;
                if (newRow >= 0 && newRow < maxRow && newColumn >= 0 && newColumn < maxColumn && heights[newRow][newColumn] >= heights[row][column])
                {
                    Visit(newRow, newColumn, heights, visted);
                }
            }
        }
    }
}
