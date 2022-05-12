using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class graph_valid_tree
    {
        public bool ValidTree(int n, int[][] edges)
        {
            var parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            foreach (var item in edges)
            {
                if (Find(parents, item[0]) == Find(parents, item[1]))
                {
                    return false;
                }

                Merge(parents, item[0], item[1]);
            }

            var res = 0;
            for (int i = 0; i < n; i++)
            {
                if (parents[i] == i)
                {
                    res++;
                }
            }

            return res == 1;
        }

        private int Find(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                parents[i] = Find(parents, parents[i]);
                return parents[i];
            }
        }

        private void Merge(int[] parents, int i, int j)
        {
            var left = Math.Min(i, j);
            var right = Math.Max(i, j);
            parents[Find(parents, right)] = parents[Find(parents, left)];
        }
    }
}
