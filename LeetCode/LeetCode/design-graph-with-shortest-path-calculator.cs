using System;
using System.Collections.Generic;

namespace LeetCode;

public class design_graph_with_shortest_path_calculator
{
    public class Graph {
        private IList<int[]>[] graph;

        public Graph(int n, int[][] edges) {
            graph = new IList<int[]>[n];
            for (int i = 0; i < n; i++) {
                graph[i] = new List<int[]>();
            }
            foreach (int[] edge in edges) {
                int x = edge[0];
                int y = edge[1];
                int cost = edge[2];
                graph[x].Add(new int[]{y, cost});
            }
        }
    
        public void AddEdge(int[] edge) {
            int x = edge[0];
            int y = edge[1];
            int cost = edge[2];
            graph[x].Add(new int[]{y, cost});
        }
    
        public int ShortestPath(int node1, int node2) {
            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
            int[] dist = new int[graph.Length];
            Array.Fill(dist, int.MaxValue);
            dist[node1] = 0;
            pq.Enqueue(new int[]{0, node1}, 0);
            while (pq.Count > 0) {
                int[] arr = pq.Dequeue();
                int cost = arr[0], cur = arr[1];
                if (cur == node2) {
                    return cost;
                }
                foreach (int[] nextArr in graph[cur]) {
                    int next = nextArr[0], ncost = nextArr[1];
                    if (dist[next] > cost + ncost) {
                        dist[next] = cost + ncost;
                        pq.Enqueue(new int[]{cost + ncost, next}, cost + ncost);
                    }
                }
            }
            return -1;
        }
    }
}