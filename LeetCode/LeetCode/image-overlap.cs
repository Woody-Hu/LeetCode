using System;
namespace LeetCode
{
	public class image_overlap
	{
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            var n = img1.Length;
            var count = new int[2 * n + 1, 2 * n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (img1[i][j] == 1)
                    {
                        for (int i2 = 0; i2 < n; i2++)
                        {
                            for (int j2 = 0; j2 < n; j2++)
                            {
                                if (img2[i2][j2] == 1)
                                {
                                    count[i - i2 + n, j - j2 + n] += 1;
                                }
                            }
                        }
                    }
                }
            }

            var res = 0;
            foreach (var row in count)
            {
                res = Math.Max(res, row);
            }

            return res;
        }
    }
}

