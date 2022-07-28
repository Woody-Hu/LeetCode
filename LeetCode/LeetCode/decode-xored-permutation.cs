using System;
namespace LeetCode
{
    public class decode_xored_permutation
    {
        public int[] Decode(int[] encoded)
        {
            var n = encoded.Length + 1;
            var total = 0;
            for (int i = 0; i <= n; i++)
            {
                total ^= i;
            }

            var odd = 0;
            for (int i = 1; i < n - 1; i+= 2)
            {
                odd ^= encoded[i];
            }

            var res = new int[n];
            res[0] = total ^ odd;
            for (int i = 0; i < n - 1; i++)
            {
                res[i + 1] = res[i] ^ encoded[i];
            }

            return res;
        }
    }
}
