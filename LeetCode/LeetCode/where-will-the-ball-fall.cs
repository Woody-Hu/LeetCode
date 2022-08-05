using System;
namespace LeetCode
{
    public class where_will_the_ball_fall
    {
        public int[] FindBall(int[][] grid)
        {
            var res = new int[grid[0].Length];
            for (int i = 0; i < grid[0].Length; i++)
            {
                var col = i;
                foreach (var row in grid)
                {
                    int dir = row[col];
                    col += dir;  
                    if (col < 0 || col == grid[0].Length || row[col] != dir)
                    { 
                        col = -1;
                        break;
                    }
                }

                res[i] = col;
            }

            return res;
        }
    }
}
