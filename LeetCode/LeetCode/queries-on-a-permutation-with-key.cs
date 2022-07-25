using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class queries_on_a_permutation_with_key
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            List<int> perm = new List<int>();
            for (int i = 1; i <= m; i++)
                perm.Add(i);
            for (int i = 0; i < queries.Length; i++)
            {
                int query = queries[i], idx = perm.IndexOf(query);
                queries[i] = idx;
                perm.RemoveAt(idx);
                perm.Insert(0, query);
            }
            return queries;
        }
    }
}
