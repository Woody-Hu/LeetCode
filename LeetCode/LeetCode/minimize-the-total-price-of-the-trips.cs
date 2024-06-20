using System;
using System.Collections.Generic;

namespace LeetCode;

public class minimize_the_total_price_of_the_trips
{
    public int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips) {
        IList<int>[] next = new IList<int>[n];
        for (int i = 0; i < n; i++) {
            next[i] = new List<int>();
        }
        foreach (int[] edge in edges) {
            next[edge[0]].Add(edge[1]);
            next[edge[1]].Add(edge[0]);
        }

        int[] count = new int[n];
        foreach (int[] trip in trips) {
            DFS(trip[0], -1, trip[1], next, count);
        }

        int[] pair = DP(0, -1, price, next, count);
        return Math.Min(pair[0], pair[1]);
    }
    
    
    private bool DFS(int node, int parent, int end, IList<int>[] next, int[] count) {
        if (node == end) {
            count[node]++;
            return true;
        }
        
        foreach (var child in next[node]) {
            if (child == parent) {
                continue;
            }
            if (DFS(child, node, end, next, count)) {
                count[node]++;
                return true;
            }
        }
        return false;
    }

    private int[] DP(int node, int parent, int[] price, IList<int>[] next, int[] count) {
        int[] res = {price[node] * count[node], price[node] * count[node] / 2};
        foreach (int child in next[node]) {
            if (child == parent) {
                continue;
            }
            
            int[] pair = DP(child, node, price, next, count);
            res[0] += Math.Min(pair[0], pair[1]); 
            res[1] += pair[0]; 
        }
        return res;
    }
}