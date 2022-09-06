using System;
namespace LeetCode
{
    public class minimum_swaps_to_make_strings_equal
    {
        public int MinimumSwap(string s1, string s2)
        {
            var xy = 0;
            var yx = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                var c1 = s1[i];
                var c2 = s2[i];
                if (c1 == c2)
                {
                    continue;
                }
                else if (c1 == 'x')
                {
                    xy++;
                }
                else
                {
                    yx++;
                }
            }

            if (((xy + yx) & 1) != 0)
            {
                return -1;
            }

            return xy / 2 + yx / 2 + ((xy % 2) * 2);
        }
    }
}
