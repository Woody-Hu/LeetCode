using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class difference_of_number_of_distinct_values_on_diagonals
	{
        public int[][] DifferenceOfDistinctValues(int[][] grid)
        {
            var res = new int[grid.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[grid[0].Length];
            }

            var tls = new HashSet<int>();
            var brs = new HashSet<int>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    var tI = i;
                    var tJ = j;
                    while (tI -- != 0 && tJ-- != 0)
                    {
                        tls.Add(grid[tI][tJ]);
                    }

                    tI = i;
                    tJ = j;

                    while (tI++ != grid.Length - 1 && tJ ++ != grid[0].Length - 1)
                    {
                        brs.Add(grid[tI][tJ]);
                    }

                    res[i][j] = Math.Abs(tls.Count - brs.Count);

                    tls.Clear();
                    brs.Clear();
                }
            }

            return res;
        }
    }
}

