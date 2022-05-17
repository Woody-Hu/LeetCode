using System;
namespace LeetCode
{
    public class lonely_pixel_ii
    {
        public int FindBlackPixel(char[][] picture, int target)
        {
            var m = picture.Length;
            var n = picture[0].Length;
            int[] row = new int[m];
            int[] col = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (picture[i][j] == 'B')
                    {
                        row[i]++;
                        col[j]++;
                    }
                }
            }

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (col[i] == target)
                {
                    int first = -1;
                    int sum = 0;
                    for (int h = 0; h < m; h++)
                    {
                        if (picture[h][i] == 'B')
                        {
                            if (row[h] != target)
                                break;
                            if (first == -1)
                                first = h;
                            else if (!RowEquals(picture, first, h))
                                break;
                            sum++;
                        }
                    }
                    if (sum == target) res += sum;
                }
            }
            return res;

        }

        private bool RowEquals(char[][] picture, int row1, int row2)
        {
            for (int i = 0; i < picture[row1].Length; i++)
            {
                if (picture[row1][i] != picture[row2][i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
