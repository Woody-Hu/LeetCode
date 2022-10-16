using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class merge_similar_items
    {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            int[] table = new int[1001];
            int n1 = items1.Length, n2 = items2.Length;
            for (int i = 0; i < n1; i++)
                table[items1[i][0]] += items1[i][1];
            for (int i = 0; i < n2; i++)
                table[items2[i][0]] += items2[i][1];

            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < 1001; i++)
            {
                if (table[i] > 0)
                    res.Add(new List<int>() { i, table[i] });
            }
            return res;
        }
    }
}

