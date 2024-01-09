using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class chuan_di_xin_xi
	{
        public int NumWays(int n, int[][] relation, int k)
        {
            var ways = 0;
            var edges = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                edges.Add(new List<int>());
            }

            foreach (var item in relation)
            {
                var src = item[0];
                var dst = item[1];
                edges[src].Add(dst);
            }

            DFS(0, 0, k, n, ref ways, ref edges);
            return ways;

        }

        public void DFS(int index, int steps, int k, int n, ref int ways, ref List<List<int>> edges)
        {
            if (steps == k)
            {
                if (index == n - 1)
                {
                    ways++;
                }
                return;
            }
            IList<int> list = edges[index];
            foreach (int nextIndex in list)
            {
                DFS(nextIndex, steps + 1, k, n, ref ways, ref edges);
            }
        }
    }
}

