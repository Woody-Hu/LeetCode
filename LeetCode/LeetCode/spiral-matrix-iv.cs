using System;
namespace LeetCode
{
    public class spiral_matrix_iv
    {
        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            var matrix = new int[m][];
            var visited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                var arr = new int[n];
                Array.Fill(arr, -1);
                matrix[i] = arr;
                visited[i] = new bool[n];
            }

            var dirs = new int[][]
            {
                    new int[]{0,1},
                    new int[]{1,0},
                    new int[]{0,-1},
                    new int[]{-1,0}
            };

            int x = 0;
            int y = 0;
            int index = 0;
            while (head != null)
            {
                matrix[x][y] = head.val;
                head = head.next;
                visited[x][y] = true;
                int x1 = x + dirs[index][0];
                int y1 = y + dirs[index][1];
                if (x1 < 0 || x1 >= m || y1 < 0 || y1 >= n || visited[x1][y1]) 
                {
                    index = (index + 1) % 4;
                }

                x += dirs[index][0];
                y += dirs[index][1];
            }

            return matrix;
        }
    }
}
