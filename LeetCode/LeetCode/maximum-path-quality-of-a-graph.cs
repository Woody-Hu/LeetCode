using System;
using System.Collections.Generic;

namespace LeetCode;

public class maximum_path_quality_of_a_graph
{
    int ans = 0;
    int[] values;
    int maxTime;
    IList<int[]>[] g;
    bool[] visited;
        
    public int MaximalPathQuality(int[] values, int[][] edges, int maxTime) {
        this.values = values;
        this.maxTime = maxTime;
        int n = values.Length;
        g = new IList<int[]>[n];
        for (int i = 0; i < n; i++) {
            g[i] = new List<int[]>();
        }
        foreach (int[] edge in edges) {
            g[edge[0]].Add(new int[]{edge[1], edge[2]});
            g[edge[1]].Add(new int[]{edge[0], edge[2]});
        }

        visited = new bool[n];
        visited[0] = true;
        
        DFS(0, 0, values[0]);
        return ans;
    }

    public void DFS(int u, int time, int value) {
        if (u == 0) {
            ans = Math.Max(ans, value);
        }
        foreach (int[] arr in g[u]) {
            int v = arr[0], dist = arr[1];
            if (time + dist <= maxTime) {
                if (!visited[v]) {
                    visited[v] = true;
                    DFS(v, time + dist, value + values[v]);
                    visited[v] = false;
                } else {
                    DFS(v, time + dist, value);
                }
            }
        }
    }
}