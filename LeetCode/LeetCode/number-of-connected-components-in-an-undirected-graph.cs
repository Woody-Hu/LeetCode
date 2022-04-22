using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class number_of_connected_components_in_an_undirected_graph
    {
        public int CountComponents(int n, int[][] edges)
        {
            var parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            foreach (var item in edges)
            {
                Merge(Math.Min(item[0], item[1]), Math.Max(item[0], item[1]), parents);
            }

            var set = new HashSet<int>();
            foreach (var item in parents)
            {
                set.Add(Find(item, parents));
            }

            return set.Count;
        }

        private int Find(int i, int[] parents)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                parents[i] = Find(parents[i], parents);
                return parents[i];
            }
        }

        private void Merge(int i, int j, int[] parents)
        {
            parents[Find(j, parents)] = parents[Find(i, parents)];
        }
    }
}
