using System;
namespace LeetCode
{
    public class minimum_bit_flips_to_convert_number
    {
        public int MinBitFlips(int start, int goal)
        {
            var res = 0;
            var temp = start ^ goal;
            while (temp > 0)
            {
                res += temp & 1;
                temp = temp >> 1;
            }

            return res;
        }
    }
}

