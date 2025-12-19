using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximum_subgraph_score_in_a_tree
    {
        IList<int>[] adjacentArr;
        int[] nodeScores;
        int[] subtreeMaxScores;
        int[] subgraphMaxScores;

        public int[] MaxSubgraphScore(int n, int[][] edges, int[] good)
        {
            this.adjacentArr = new IList<int>[n];
            for (int i = 0; i < n; i++)
            {
                adjacentArr[i] = new List<int>();
            }
            foreach (int[] edge in edges)
            {
                adjacentArr[edge[0]].Add(edge[1]);
                adjacentArr[edge[1]].Add(edge[0]);
            }
            this.nodeScores = new int[n];
            for (int i = 0; i < n; i++)
            {
                nodeScores[i] = good[i] * 2 - 1;
            }
            this.subtreeMaxScores = new int[n];
            DFSSubtree(0, -1);
            this.subgraphMaxScores = new int[n];
            DFSSubgraph(0, -1, 0);
            return subgraphMaxScores;
        }

        public int DFSSubtree(int node, int parent)
        {
            subtreeMaxScores[node] = nodeScores[node];
            IList<int> adjacent = adjacentArr[node];
            foreach (int child in adjacent)
            {
                if (child != parent)
                {
                    int childMaxScore = DFSSubtree(child, node);
                    subtreeMaxScores[node] += Math.Max(childMaxScore, 0);
                }
            }
            return subtreeMaxScores[node];
        }

        public void DFSSubgraph(int node, int parent, int ancestorScore)
        {
            int currSubgraphMaxScore = subtreeMaxScores[node] + Math.Max(ancestorScore, 0);
            subgraphMaxScores[node] = currSubgraphMaxScore;
            IList<int> adjacent = adjacentArr[node];
            foreach (int child in adjacent)
            {
                if (child != parent)
                {
                    int currScore = currSubgraphMaxScore - Math.Max(subtreeMaxScores[child], 0);
                    DFSSubgraph(child, node, currScore);
                }
            }
        }
    }
}
