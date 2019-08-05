using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Friend_Circles
    {
        public int FindCircleNum(int[][] M)
        {
            var visited = new int[M.Length];
            var res = 0;
            if (M.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < M.Length; i++)
            {
                if (visited[i] == 0)
                {
                    FindCircleNum(M, visited, i);
                    res++;
                }
            }

            return res;
        }

        private void FindCircleNum(int[][] M, int[] visited, int index)
        {
            for (int i = 0; i < M.Length; i++)
            {
                if (visited[i] == 0 && M[index][i] == 1)
                {
                    visited[i] = 1;
                    FindCircleNum(M, visited, i);
                }
            }
        }
    }
}
