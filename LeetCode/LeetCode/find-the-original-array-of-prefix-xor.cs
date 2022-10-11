using System;
namespace LeetCode
{
    public class find_the_original_array_of_prefix_xor
    {
        public int[] FindArray(int[] pref)
        {
            var res = new int[pref.Length];
            res[0] = pref[0];
            for (int i = 1; i < pref.Length; i++)
            {
                res[i] = pref[i] ^ pref[i - 1];
            }

            return res;
        }
    }
}

