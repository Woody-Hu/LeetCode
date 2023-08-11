using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class is_graph_bipartite
	{
        public bool IsBipartite(int[][] graph)
        {
            var n = graph.Length;
            var color = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (color[i] == 0)
                {
                    var queue = new Queue<int>();
                    queue.Enqueue(i);
                    color[i] = 1;
                    while (queue.Any())
                    {
                        var ni = queue.Dequeue();
                        var newC = color[ni] == 1 ? 2 : 1;
                        foreach (var item in graph[ni])
                        {
                            if (color[item] == 0)
                            {
                                queue.Enqueue(item);
                                color[item] = newC;
                            }
                            else if (color[item] != newC)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}

