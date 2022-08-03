using System;
namespace LeetCode
{
    public class spiral_matrix_iii
    {
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            var dr = new int[] { 0, 1, 0, -1 };
            var dc = new int[] { 1, 0, -1, 0 };
            var ans = new int[rows * cols][];
            for (int i = 0; i < rows * cols; i++)
            {
                ans[i] = new int[2];
            }

            int t = 0;
            ans[t++] = new int[] { rStart, cStart };
            if (rows * cols == 1)
                return ans;
            for (int k = 1; k < 2 * (rows + cols); k += 2)
            {
                for (int i = 0; i < 4; ++i)
                {  
                    int dk = k + (i / 2);
                    for (int j = 0; j < dk; ++j)
                    {
                        rStart += dr[i];
                        cStart += dc[i];
                        if (0 <= rStart && rStart < rows && 0 <= cStart && cStart < cols)
                        {
                            ans[t++] = new int[] { rStart, cStart };
                            if (t == rows * cols) return ans;
                        }
                    }
                 }
            }

            return null;
         }
     }
}

