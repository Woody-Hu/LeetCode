using System;
namespace LeetCode
{
    public class xor_queries_of_a_subarray
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            var n = arr.Length;
            var xorRes = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                xorRes[i + 1] = xorRes[i] ^ arr[i];
            }

            var res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                res[i] = xorRes[queries[i][0]] ^ xorRes[queries[i][1] + 1];
            }

            return res;
        }
    }
}
