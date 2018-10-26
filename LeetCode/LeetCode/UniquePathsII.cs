using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniquePathsII
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int rowLength = obstacleGrid.GetLength(0);
            int columnLength = obstacleGrid.GetLength(1);
            int[,] paths = new int[rowLength + 1, columnLength + 1];
            paths[1, 0] = 1;

            for (int i = 1; i <= rowLength; i++)
            {
                for (int j = 1; j <= columnLength; j++)
                {
                    if (obstacleGrid[i-1,j-1] != 0)
                    {
                        continue;
                    }

                    paths[i, j] = paths[i - 1, j] + paths[i, j - 1];
                }
            }

            return paths[rowLength, columnLength];




        }
    }
}
