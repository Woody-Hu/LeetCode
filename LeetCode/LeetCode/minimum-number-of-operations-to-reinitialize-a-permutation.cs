using System;
namespace LeetCode
{
    public class minimum_number_of_operations_to_reinitialize_a_permutation
    {
        public int ReinitializePermutation(int n)
        {
            if (n == 2)
            {
                return 1;
            }

            var res = 1;
            var k = 2;
            while (k != 1)
            {
                res++;
                k = k * 2 % (n - 1);
            }

            return res;
        }
    }
}
