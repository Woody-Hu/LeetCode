using System.Collections.Generic;

namespace LeetCode;

public class count_pairs_of_connectable_servers_in_a_weighted_tree_network
{
    public int[] CountPairsOfConnectableServers(int[][] edges, int signalSpeed) {
        var n = edges.Length + 1;
        var graph = new IList<int[]>[n];
        for (var i = 0; i < n; i++) {
            graph[i] = new List<int[]>();
        }
        foreach (var e in edges) {
            var u = e[0];
            var v = e[1];
            var cost = e[2];
            graph[u].Add(new int[] {v, cost});
            graph[v].Add(new int[] {u, cost});
        }
        
        var res = new int[n];
        for (int i = 0; i < n; i++) {
            int pre = 0;
            foreach (int[] e in graph[i]) {
                int cnt = DFS(e[0], i, e[1] % signalSpeed, signalSpeed, graph);
                res[i] += pre * cnt;
                pre += cnt;
            }
        }
        
        return res;
    }
    
    private int DFS(int p, int root, int curr, int signalSpeed, IList<int[]>[] graph) {
        var res = 0;
        if (curr == 0) {
            res++;
        }
        
        foreach (var e in graph[p]) {
            var v = e[0];
            var cost = e[1];
            if (v != root) {
                res += DFS(v, p, (curr + cost) % signalSpeed, signalSpeed, graph);
            }
        }
        return res;
    }
}