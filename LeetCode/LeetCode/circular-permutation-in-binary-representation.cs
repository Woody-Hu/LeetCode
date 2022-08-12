using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class circular_permutation_in_binary_representation
    {
        public IList<int> CircularPermutation(int n, int start)
        {
            var res = new List<int>();
            var total = 1 << n;
            for (int i = 0; i < total; i++)
            {
                res.Add((i >> 1) ^ i ^ start);
            }

            return res;
        }
    }
}
