using System;
using System.Collections.Generic;

namespace LeetCode;

public class parallel_courses_iii
{
    public int MinimumTime(int n, int[][] relations, int[] time) {
        int mx = 0;
        IList<int>[] prev = new IList<int>[n + 1];
        for (int i = 0; i <= n; i++) {
            prev[i] = new List<int>();
        }
        foreach (int[] relation in relations) {
            int x = relation[0], y = relation[1];
            prev[y].Add(x);
        }
        IDictionary<int, int> memo = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++) {
            mx = Math.Max(mx, DP(i, time, prev, memo));
        }
        return mx;
    }

    public int DP(int i, int[] time, IList<int>[] prev, IDictionary<int, int> memo) {
        if (!memo.ContainsKey(i)) {
            int cur = 0;
            foreach (int p in prev[i]) {
                cur = Math.Max(cur, DP(p, time, prev, memo));
            }
            cur += time[i - 1];
            memo.Add(i, cur);
        }
        return memo[i];
    }
    
}