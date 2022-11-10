using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_all_groups_of_farmland
    {
        public int[][] FindFarmland(int[][] land)
        {
            var res = new List<int[]>();
            var m = land.Length;
            var n = land[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (land[i][j] == 0)
                    {
                        continue;
                    }

                    var row = i;
                    var col = j;
                    while (row + 1 < m && land[row+1][j] == 1)
                    {
                        row++;
                    }

                    while (col + 1 <n && land[i][col + 1] == 1)
                    {
                        col++;
                    }

                    for (int x = i; x <= row; x++)
                    {
                        for (int y = j; y <= col; y++)
                        {
                            land[x][y] = 0;
                        }
                    }

                    res.Add(new int[] { i, j, row, col });
                }
            }

            return res.ToArray();
        }
    }
}
