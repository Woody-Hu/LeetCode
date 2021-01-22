using System;
namespace LeetCode
{
    public class Decode_XORed_Array
    {
        public int[] Decode(int[] encoded, int first)
        {
            var res = new int[encoded.Length + 1];
            res[0] = first;
            for (int i = 0; i < encoded.Length; i++)
            {
                res[i + 1] = res[i] ^ encoded[i];
            }

            return res;
        }
    }
}
