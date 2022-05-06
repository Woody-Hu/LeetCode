using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class number_of_corner_rectangles
    {
        public int CountCornerRectangles(int[][] grid)
        {
            var dic = new Dictionary<int, int>();
            var res = 0;
            foreach (var item in grid)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == 1)
                    {
                        for (int j = i + 1; j < item.Length; j++)
                        {
                            if (item[j] == 1)
                            {
                                var pos = i * 200 + j;
                                var current = dic.GetValueOrDefault(pos, 0);
                                res += current;
                                dic[pos] = current + 1;
                            }
                        }
                    }

                }
            }

            return res;
        }
    }
}
