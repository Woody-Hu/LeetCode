using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class find_the_kth_smallest_sum_of_a_matrix_with_sorted_rows
{
    public int KthSmallest(int[][] mat, int k) {
        int m = mat.Length;
        int[] prev = mat[0];
        for (int i = 1; i < m; ++i) {
            prev = Merge(prev, mat[i], k);
        }
        return prev[k - 1];
    }

    public int[] Merge(int[] f, int[] g, int k) {
        if (g.Length > f.Length) {
            return Merge(g, f, k);
        }

        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
        for (int i = 0; i < g.Length; ++i) {
            pq.Enqueue(new int[]{0, i, f[0] + g[i]}, f[0] + g[i]);
        }

        IList<int> list = new List<int>();
        while (k > 0 && pq.Count > 0) {
            int[] entry = pq.Dequeue();
            list.Add(entry[2]);
            if (entry[0] + 1 < f.Length) {
                pq.Enqueue(new int[]{entry[0] + 1, entry[1], f[entry[0] + 1] + g[entry[1]]}, f[entry[0] + 1] + g[entry[1]]);
            }
            --k;
        }

        return list.ToArray();
    }
}