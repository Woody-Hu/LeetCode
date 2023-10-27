using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_subtrees_with_max_distance_between_cities
	{
        public int[] CountSubgraphsForEachDiameter(int n, int[][] edges)
        {
            var adj = new IList<int>[n];
            var dist = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dist[i] = new int[n];
                Array.Fill(dist[i], int.MaxValue);
                dist[i][i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                adj[i] = new List<int>();
            }

            foreach (int[] edge in edges)
            {
                int x = edge[0] - 1;
                int y = edge[1] - 1;
                adj[x].Add(y);
                adj[y].Add(x);
                dist[x][y] = dist[y][x] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (dist[j][i] != int.MaxValue && dist[i][k] != int.MaxValue)
                        {
                            dist[j][k] = Math.Min(dist[j][k], dist[j][i] + dist[i][k]);
                        }
                    }
                }
            }

            int[] ans = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    ans[dist[i][j] - 1] += DFS(adj, dist, i, -1, i, j);
                }
            }

            return ans;
        }

        private int DFS(IList<int>[] adj, int[][] dist, int u, int parent, int x, int y)
        {
            if (dist[u][x] > dist[x][y] || dist[u][y] > dist[x][y])
            {
                return 1;
            }

            if ((dist[u][y] == dist[x][y] && u < x) || (dist[u][x] == dist[x][y] && u < y))
            {
                return 1;
            }

            var ret = 1;
            foreach (int v in adj[u])
            {
                if (v != parent)
                {
                    ret *= DFS(adj, dist, v, u, x, y);
                }
            }

            if (dist[u][x] + dist[u][y] > dist[x][y])
            {
                ret++;
            }

            return ret;

        }
    }
}

