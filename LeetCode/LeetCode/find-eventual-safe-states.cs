using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_eventual_safe_states
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            var res = new List<int>();
            var array = new int[graph.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (IsSafe(graph, array, i))
                {
                    res.Add(i);
                }
            }

            return res;
        }

        private bool IsSafe(int[][] graph, int[] color, int i)
        {
            if (color[i] > 0)
            {
                return color[i] == 2;
            }

            color[i] = 1;
            foreach (var item in graph[i])
            {
                if (!IsSafe(graph, color, item))
                {
                    return false;
                }
            }

            color[i] = 2;
            return true;
        }
    }
}
