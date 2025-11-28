using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximum_number_of_k_divisible_components
    {
        public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
        {
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; ++i)
            {
                graph[i] = new List<int>();
            }
            foreach (var edge in edges)
            {
                int u = edge[0], v = edge[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }

            int result = 0;

            long Dfs(int node, int parent)
            {
                long sum = values[node];
                foreach (int neighbor in graph[node])
                {
                    if (neighbor != parent)
                    {
                        sum += Dfs(neighbor, node);
                    }
                }
                if (sum % k == 0)
                {
                    result++;
                }
                return sum;
            }

            Dfs(0, -1);
            return result;
        }
    }
}
