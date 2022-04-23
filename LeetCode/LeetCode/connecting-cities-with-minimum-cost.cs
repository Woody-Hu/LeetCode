using System;
using System.Linq;

namespace LeetCode
{
    public class connecting_cities_with_minimum_cost
    {
        public int MinimumCost(int n, int[][] connections)
        {
            var ordered = connections.OrderBy(k => k[2]);
            var parents = new int[n];
            var count = 0;
            var res = 0;
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            foreach (var item in ordered)
            {
                if (Find(parents, item[0] - 1) == Find(parents, item[1] - 1))
                {
                    continue;
                }

                Merge(parents, item[0] - 1, item[1] - 1);
                res += item[2];
                count++;
            }

            if (count < n - 1)
            {
                return -1;
            }

            return res;
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
            var left = i;
            var right = j;
            if (j < i)
            {
                left = j;
                right = i;
            }

            parents[Find(parents, right)] = parents[Find(parents, left)];
        }

    }
}

