using System;
namespace LeetCode
{
	public class find_champion_i
	{
        public int FindChampion(int[][] grid)
        {
            var n = grid.Length;
            for (int j = 0; ; j++)
            {
                var res = true;
                for (int i = 0; i < n; i++)
                {
                    if (grid[i][j] != 0)
                    {
                        res = false;
                        break;
                    }
                }

                if (res)
                {
                    return j;
                }
            }
        }
    }
}

