using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class bP4bmD
	{
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var res = new List<IList<int>>();
            var list = new List<int>();
            list.Add(0);
            DFS(graph, 0, graph.Length - 1, res, list);
            return res;
        }

        private void DFS(int[][] graph, int x, int n, List<IList<int>> res, List<int> list)
        {
            if (x == n)
            {
                res.Add(new List<int>(list));
                return;
            }

            foreach (var item in graph[x])
            {
                list.Add(item);
                DFS(graph, item, n, res, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}

