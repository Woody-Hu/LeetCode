using System.Collections.Generic;

namespace LeetCode;

public class couples_holding_hands
{
    public int MinSwapsCouples(int[] row) {
        var n = row.Length;
        var total = n / 2;
        var graph = new List<int>[total];
        for (var i = 0; i < total; i++)
        {
            graph[i] = new List<int>();
        }
        
        for (var i = 0; i < n; i += 2)
        {
            var l = row[i] / 2;
            var r = row[i + 1] / 2;
            if (l != r)
            {
                graph[l].Add(r);
                graph[r].Add(l);
            }
        }
        
        var visited = new bool[total];
        var res = 0;
        for (var i = 0; i < total; i++)
        {
            if (!visited[i])
            {
                var queue = new Queue<int>();
                queue.Enqueue(i);
                visited[i] = true;
                var cnt = 0;
                while (queue.Count > 0)
                {
                    var u = queue.Dequeue();
                    cnt++;
                    foreach (var v in graph[u])
                    {
                        if (!visited[v])
                        {
                            visited[v] = true;
                            queue.Enqueue(v);
                        }
                    }
                }
                res += cnt - 1;
            }
        }
        
        return res;
        
    }
}