using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class letter_tile_possibilities
    {
        public int NumTilePossibilities(string tiles)
        {
            var set = new HashSet<string>();
            var used = new bool[tiles.Length];
            var res = 0;
            for (int i = 1; i <= tiles.Length; i++)
            {
                Calculate(tiles, string.Empty, i, used, set, ref res);
            }

            return res;
        }

        private void Calculate(string tiles, string curs, int expectLength, bool[] used, HashSet<string> set, ref int res)
        {
            if (curs.Length == expectLength && !set.Contains(curs))
            {
                set.Add(curs);
                res++;
                return;
            }

            for (int i = 0; i < tiles.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    Calculate(tiles, curs + tiles[i], expectLength, used, set, ref res);
                    used[i] = false;
                }
            }
        }
    }
}
