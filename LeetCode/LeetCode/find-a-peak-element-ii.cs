using System;
namespace LeetCode
{
    public class find_a_peak_element_ii
    {
        public int[] FindPeakGrid(int[][] mat)
        {
            var m = mat.Length;
            var n = mat[0].Length;
            var l = -1;
            var r = m;
            while (l + 1 < m)
            {
                var current = (r + l) / 2;
                var maxCol = FindMaxId(mat[current]);
                if (current == m - 1 || mat[current][maxCol] > mat[current + 1][maxCol])
                {
                    r = current;
                }
                else
                {
                    l = current;
                }
            }

            var j = FindMaxId(mat[r]);
            return new int[] { r, j };
        }

        private int FindMaxId(int[] input)
        {
            var res = -1;
            var max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]> max)
                {
                    max = input[i];
                    res = i;
                }
            }

            return res;
        }
    }
}
