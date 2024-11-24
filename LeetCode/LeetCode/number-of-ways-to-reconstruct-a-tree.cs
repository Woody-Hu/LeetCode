using System.Collections.Generic;

namespace LeetCode;

public class number_of_ways_to_reconstruct_a_tree
{
    public int CheckWays(int[][] pairs) {
         Dictionary<int, ISet<int>> adj = new Dictionary<int, ISet<int>>();
        foreach (int[] p in pairs) {
            if (!adj.ContainsKey(p[0])) {
                adj.Add(p[0], new HashSet<int>());
            }
            if (!adj.ContainsKey(p[1])) {
                adj.Add(p[1], new HashSet<int>());
            }
            adj[p[0]].Add(p[1]);
            adj[p[1]].Add(p[0]);
        }
        int root = -1;
        foreach (KeyValuePair<int, ISet<int>> pair in adj) {
            int node = pair.Key;
            ISet<int> neighbours = pair.Value;
            if (neighbours.Count == adj.Count - 1) {
                root = node;
            }
        }
        if (root == -1) {
            return 0;
        }

        int res = 1;
        foreach (KeyValuePair<int, ISet<int>> pair in adj) {
            int node = pair.Key;
            ISet<int> neighbours = pair.Value;
            if (node == root) {
                continue;
            }
            int currDegree = neighbours.Count;
            int parent = -1;
            int parentDegree = int.MaxValue;
            
            foreach (int neighbour in neighbours) {
                if (adj[neighbour].Count < parentDegree && adj[neighbour].Count >= currDegree) {
                    parent = neighbour;
                    parentDegree = adj[neighbour].Count;
                }
            }
            if (parent == -1) {
                return 0;
            }
            
            foreach (int neighbour in neighbours) {
                if (neighbour == parent) {
                    continue;
                }
                if (!adj[parent].Contains(neighbour)) {
                    return 0;
                }
            }
            if (parentDegree == currDegree) {
                res = 2;
            }
        }
        
        return res;
    }
}