using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _01_Matrix
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            var queue = new Queue<int[]>();

            var directions = new List<int[]>() {new int[] {1,0}, new int[]{0,1},new int[]{-1,0},new int[]{0,-1}};

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        queue.Enqueue(new int[] {i,j});
                    }
                    else
                    {
                        matrix[i][j] = int.MaxValue;
                    }
                }
            }

            while (queue.Count != 0)
            {
                var value = queue.Dequeue();
                foreach (var direction in directions)
                {
                    var x = value[0] + direction[0];
                    var y = value[1] + direction[1];
                    if (x < 0 || x >= matrix.Length || y < 0 || y >= matrix[0].Length)
                    {
                        continue;
                    }

                    if (matrix[x][y] <= matrix[value[0]][value[1]] + 1)
                    {
                        continue;
                    }

                    matrix[x][y] = matrix[value[0]][value[1]] + 1;

                    queue.Enqueue(new int[]{x,y});
                }
            }

            return matrix;
        }
    }
}
