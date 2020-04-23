using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Rank_Transform_of_an_Array
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var res = new int[arr.Length];
            arr.CopyTo(res, 0);
            Array.Sort(res);
            var dict = new Dictionary<int, int>();
            var currentRank = 1;
            foreach (var item in res)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, currentRank++);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = dict[arr[i]];
            }

            return res;
        }

    }
}
