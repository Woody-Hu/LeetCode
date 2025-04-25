using System;
using System.Collections.Generic;

namespace LeetCode;

public class find_critical_and_pseudo_critical_edges_in_minimum_spanning_tree
{
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges) {
        IList<int> criticalEdges = new List<int>();
        IList<int> pseudoCriticalEdges = new List<int>();
        int m = edges.Length;
        int[][] edgesIndices = new int[m][];
        for (int i = 0; i < m; i++) {
            edgesIndices[i] = new int[4];
            Array.Copy(edges[i], 0, edgesIndices[i], 0, 3);
            edgesIndices[i][3] = i;
        }
        Array.Sort(edgesIndices, (a, b) => a[2] - b[2]);
        bool[] included = new bool[m];
        Array.Fill(included, true);
        int mstWeight = Kruskal(n, edgesIndices, included, -1);
        for (int i = 0; i < m; i++) {
            int index = edgesIndices[i][3];
            included[i] = false;
            if (Kruskal(n, edgesIndices, included, -1) > mstWeight) {
                criticalEdges.Add(index);
            } else if (Kruskal(n, edgesIndices, included, i) == mstWeight) {
                pseudoCriticalEdges.Add(index);
            }
            included[i] = true;
        }
        IList<IList<int>> criticalAndPseudoCriticalEdges = new List<IList<int>>();
        criticalAndPseudoCriticalEdges.Add(criticalEdges);
        criticalAndPseudoCriticalEdges.Add(pseudoCriticalEdges);
        return criticalAndPseudoCriticalEdges;
    }

    public int Kruskal(int n, int[][] edgesIndices, bool[] included, int startEdgeIndex) {
        int mstWeight = 0;
        UnionFind uf = new UnionFind(n);
        if (startEdgeIndex >= 0) {
            int[] startEdge = edgesIndices[startEdgeIndex];
            mstWeight += startEdge[2];
            uf.Union(startEdge[0], startEdge[1]);
        }
        int m = edgesIndices.Length;
        for (int i = 0; i < m && uf.GetCount() > 1; i++) {
            if (!included[i]) {
                continue;
            }
            int[] edge = edgesIndices[i];
            int vertex0 = edge[0], vertex1 = edge[1], weight = edge[2];
            if (uf.Find(vertex0) != uf.Find(vertex1)) {
                mstWeight += weight;
                uf.Union(vertex0, vertex1);
            }
        }
        return uf.GetCount() == 1 ? mstWeight : int.MaxValue;
    }
    
    class UnionFind
    {
        private int[] parent;
        private int[] rank;
        private int count;

        public UnionFind(int n)
        {
            parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            rank = new int[n];
            this.count = n;
        }

        public void Union(int x, int y)
        {
            int rootx = Find(x);
            int rooty = Find(y);
            if (rootx != rooty)
            {
                if (rank[rootx] > rank[rooty])
                {
                    parent[rooty] = rootx;
                }
                else if (rank[rootx] < rank[rooty])
                {
                    parent[rootx] = rooty;
                }
                else
                {
                    parent[rooty] = rootx;
                    rank[rootx]++;
                }

                count--;
            }
        }

        public int Find(int x)
        {
            if (parent[x] != x)
            {
                parent[x] = Find(parent[x]);
            }

            return parent[x];
        }

        public int GetCount()
        {
            return count;
        }
    }

}