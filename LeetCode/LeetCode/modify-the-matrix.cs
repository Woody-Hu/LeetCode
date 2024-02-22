using System;
using System.Collections.Generic;
namespace LeetCode
{
	public class modify_the_matrix
	{
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var result = new int[m][];
            for (var i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    result[i][j] = matrix[i][j];
                }
            }

            for (var i = 0; i < n; i++)
            {
               var maxValue = -1;
               var modifiedIndexes = new List<int>();
               for (var j = 0; j < m; j++)
               {
                   result[j][i] = matrix[j][i];

                   if(result[j][i] == -1)
                   {
                          modifiedIndexes.Add(j);
                   }
                   else
                   {
                          maxValue = Math.Max(maxValue, result[j][i]);
                   }
               }

                foreach(var index in modifiedIndexes)
                {
                     result[index][i] = maxValue;
                }
            }

            return result;
        }
    }
}

