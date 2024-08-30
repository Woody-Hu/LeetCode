using System;

namespace LeetCode;

public class LpjUW {
    public int[] FindRedundantConnection(int[][] edges)
    {
        var n = edges.Length;
        var parent = new int[n + 1];
        for (var i = 0; i < n + 1; i++)
        {
            parent[i] = i;
        }
        
        foreach (var edge in edges)
        {
            var left = edge[0];
            var right = edge[1];
            if (find(parent, left) == find(parent, right))
            {
                return edge;
            }
            else
            {
                union(parent, left, right);
            }
        }
        
        return Array.Empty<int>();
    }

    private void union(int[] parent, int left, int right)
    {
        parent[find(parent, left)] = find(parent, right);
        
    }
    
    private int find(int[] parent, int index)
    {
        if (parent[index] != index)
        {
            parent[index] = find(parent, parent[index]);
        }
        
        return parent[index];
    }
}