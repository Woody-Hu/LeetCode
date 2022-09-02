using System;
namespace LeetCode
{
    public class rotating_the_box
    {
        const char STONE = '#';
        const char OBSTACLE = '*';
        const char EMPTY = '.';

        public char[][] RotateTheBox(char[][] box)
        {
            var m = box.Length;
            var n = box[0].Length;
            for (int i = 0; i < m; i++)
            {
                var end = n;
                for (int j = n - 1; j >= 0; j--)
                {
                    var cur = box[i][j];
                    if (cur == STONE)
                    {
                        box[i][j] = EMPTY;
                        box[i][--end] = cur;
                    }
                    else if (cur == OBSTACLE)
                    {
                        end = j;
                    }
                }
            }

            var res = new char[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new char[m];
            }

            for (int i = 0; i < m; i++)
            {
                int ansj = m - 1 - i;
                for (int j = 0; j < n; j++)
                {
                    res[j][ansj] = box[i][j];
                }
            }

            return res;
        }
    }
}
