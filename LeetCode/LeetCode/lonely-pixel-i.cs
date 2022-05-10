using System;
namespace LeetCode
{
    public class lonely_pixel_i
    {
        public int FindLonelyPixel(char[][] picture)
        {
            var n = picture.Length;
            var m = picture[0].Length;
            var res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (picture[i][j] == 'B')
                    {
                        int col = 0;
                        int row = 0;
                        for (int k = 0; k < m; ++k)
                        {
                            if (picture[i][k] == 'B')
                            {
                                row += 1;
                            }
     
                        }
                        for (int k = 0; k < n; ++k)
                        {
                            if (picture[k][j] == 'B')
                            {
                                col += 1;
                            }

                        }
                        if (row == 1 && col == 1) res++;
                    }
                }
            }

            return res;
        }
    }
}
