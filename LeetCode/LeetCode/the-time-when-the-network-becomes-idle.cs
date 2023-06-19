using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class the_time_when_the_network_becomes_idle
	{
        public int NetworkBecomesIdle(int[][] edges, int[] patience)
        {
            var n = patience.Length;
            var adj = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                adj[i] = new List<int>();
            }

            var visit = new bool[n];
            foreach (var item in edges)
            {
                adj[item[0]].Add(item[1]);
                adj[item[1]].Add(item[0]);
            }

            var queue = new Queue<int>();
            queue.Enqueue(0);
            visit[0] = true;
            var dist = 1;
            var res = 0;
            while (queue.Any())
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    foreach (var item in adj[curr])
                    {
                        if (visit[item])
                        {
                            continue;
                        }

                        queue.Enqueue(item);
                        var time = patience[item] * ((2 * dist - 1) / patience[item]) + 2 * dist + 1;
                        res = Math.Max(res, time);
                        visit[item] = true;
                    }
                }

                dist++;
            }

            return res;
        }
    }
}

