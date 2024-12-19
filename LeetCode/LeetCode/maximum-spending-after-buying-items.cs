using System.Collections.Generic;

namespace LeetCode;

public class maximum_spending_after_buying_items
{
    public long MaxSpending(int[][] values) {
        int m = values.Length, n = values[0].Length;
        var pq = new PriorityQueue<int[], int>(
            Comparer<int>.Create((a, b) => a.CompareTo(b))
        );
        
        for (var i = 0; i < m; i++) {
            pq.Enqueue(new int[]{values[i][n - 1], i, n - 1}, values[i][n - 1]);
        }
        long ans = 0;
        for (var turn = 1; turn <= m * n; turn++) {
            var top = pq.Dequeue();
            int val = top[0], i = top[1], j = top[2];
            ans += (long)val * turn;
            if (j > 0) {
                pq.Enqueue(new int[]{values[i][j - 1], i, j - 1}, values[i][j - 1]);
            }
        }
        
        return ans;
    }
}