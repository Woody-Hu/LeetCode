using System;
namespace LeetCode
{
    public class minimum_flips_to_make_a_or_b_equal_to_c
    {
        public int MinFlips(int a, int b, int c)
        {
            var res = 0;
            for (int i = 0; i < 31; i++)
            {
                var bitA = (a >> i) & 1;
                var bitB = (b >> i) & 1;
                var bitC = (c >> i) & 1;
                if (bitC == 0)
                {
                    res += bitA + bitB;
                }
                else
                {
                    if (bitA == 0 && bitB ==0)
                    {
                        res += 1;
                    }
                }

            }

            return res;
        }
    }
}
