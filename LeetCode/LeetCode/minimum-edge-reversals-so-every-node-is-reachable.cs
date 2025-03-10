using System.Collections.Generic;

namespace LeetCode;

public class minimum_edge_reversals_so_every_node_is_reachable
{
    public int[] MinEdgeReversals(int n, int[][] edges) {
        var g = new List<int[]>[n]; 
        for (var i = 0; i < n; i++)
        {
            g[i] = new List<int[]>();
        }
        
        foreach (var edge in edges)
        {
            var x = edge[0];
            var y = edge[1];
            g[x].Add(new int[]{y, 1});
            g[y].Add(new int[]{x, -1});
        }
        
        var res = new int[n];
        DFS(0,-1,g,res);
        ReRoot(0,-1,g,res);
        return res;
    }

    private void DFS(int x, int fa, List<int[]>[] g, int[] res)
    {
        foreach (var edge in g[x])
        {
            var y = edge[0];
            var dir = edge[1];
            if (y != fa)
            {
                if (dir < 0)
                {
                    res[0]++;
                }
                
                DFS(y,x,g,res);
            }
        }
    }
    
    private void ReRoot(int x, int fa, List<int[]>[] g, int[] res)
    {
        foreach (var edge in g[x])
        {
            var y = edge[0];
            var dir = edge[1];
            if (y != fa)
            {
                res[y] = res[x] + dir;
                ReRoot(y,x,g,res);
            }
        }
    }
}