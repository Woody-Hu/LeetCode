using System;
using System.Collections.Generic;

namespace LeetCode;

public class shortest_path_visiting_all_nodes
{
    public int ShortestPathLength(int[][] graph) {
        var n = graph.Length;
        var queue = new Queue<Tuple<int, int, int>>();
        var seen = new bool[n, 1 << n];
        for (var i = 0; i < n; ++i) {
            queue.Enqueue(new Tuple<int, int, int>(i, 1 << i, 0));
            seen[i, 1 << i] = true;
        }

        var ans = 0;
        while (queue.Count > 0) {
            var tuple = queue.Dequeue();
            int u = tuple.Item1, mask = tuple.Item2, dist = tuple.Item3;
            if (mask == (1 << n) - 1) {
                ans = dist;
                break;
            }
            
            foreach (var v in graph[u]) {
                var maskV = mask | (1 << v);
                if (!seen[v, maskV]) {
                    queue.Enqueue(new Tuple<int, int, int>(v, maskV, dist + 1));
                    seen[v, maskV] = true;
                }
            }
        }
        return ans;
    }
    
}