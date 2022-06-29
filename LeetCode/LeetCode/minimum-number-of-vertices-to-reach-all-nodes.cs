using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class minimum_number_of_vertices_to_reach_all_nodes
    {
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            var res = new List<int>();
            var set = new HashSet<int>();
            foreach (var item in edges)
            {
                set.Add(item[1]);
            }

            for (int i = 0; i < n; i++)
            {
                if (!set.Contains(i))
                {
                    set.Add(i);
                }
            }

            return res;
        }
    }
}
