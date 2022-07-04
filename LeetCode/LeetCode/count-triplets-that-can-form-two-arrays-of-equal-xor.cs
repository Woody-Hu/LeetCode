using System;
namespace LeetCode
{
    public class count_triplets_that_can_form_two_arrays_of_equal_xor
    {
        public int CountTriplets(int[] arr)
        {
            var s = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                s[i + 1] = s[i] ^ arr[i];
            }

            var res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (s[i] == s[j + 1])
                    {
                        res += j - i;
                    }
                }
            }

            return res;
        }
    }
}
