using System;
using System.Collections.Generic;

namespace LeetCode;

public class minimum_score_after_removals_on_a_tree
{
    public int MinimumScore(int[] nums, int[][] edges) {
        int n = nums.Length;
        List<List<int>> adj = new List<List<int>>();
        for (int i = 0; i < n; i++) {
            adj.Add(new List<int>());
        }
        foreach (var e in edges) {
            adj[e[0]].Add(e[1]);
            adj[e[1]].Add(e[0]);
        }

        int[] sum = new int[n];
        int[] in_ = new int[n];
        int[] out_ = new int[n];
        int cnt = 0;
        Dfs(0, -1, nums, adj, sum, in_, out_, ref cnt);

        int res = int.MaxValue;
        for (int u = 1; u < n; u++) {
            for (int v = u + 1; v < n; v++) {
                if (in_[v] > in_[u] && in_[v] < out_[u]) {
                    res = Math.Min(res, Calc(sum[0] ^ sum[u], sum[u] ^ sum[v], sum[v]));
                } else if (in_[u] > in_[v] && in_[u] < out_[v]) {
                    res = Math.Min(res, Calc(sum[0] ^ sum[v], sum[v] ^ sum[u], sum[u]));
                } else {
                    res = Math.Min(res, Calc(sum[0] ^ sum[u] ^ sum[v], sum[u], sum[v]));
                }
            }
        }
        return res;
    }

    private int Calc(int part1, int part2, int part3) {
        return Math.Max(part1, Math.Max(part2, part3)) - Math.Min(part1, Math.Min(part2, part3));
    }

    private void Dfs(int x, int fa, int[] nums, List<List<int>> adj, int[] sum, int[] in_, int[] out_, ref int cnt) {
        in_[x] = cnt++;
        sum[x] = nums[x];
        foreach (int y in adj[x]) {
            if (y == fa) {
                continue;
            }
            Dfs(y, x, nums, adj, sum, in_, out_, ref cnt);
            sum[x] ^= sum[y];
        }
        out_[x] = cnt;
    }
}