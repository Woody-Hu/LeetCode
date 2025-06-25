using System;
using System.Collections.Generic;

namespace LeetCode;

public class selling_pieces_of_wood
{
    public long SellingWood(int m, int n, int[][] prices) {
        Dictionary<long, int> value = new Dictionary<long, int>();
        foreach (int[] price in prices) {
            value[PairHash(price[0], price[1])] = price[2];
        }

        long[,] memo = new long[m + 1, n + 1];
        for (int i = 0; i <= m; i++) {
            for (int j = 0; j <= n; j++) {
                memo[i, j] = -1;
            }
        }
        return Dfs(m, n, value, memo);
    }

    public long Dfs(int x, int y, Dictionary<long, int> value, long[,] memo) {
        if (memo[x, y] != -1) {
            return memo[x, y];
        }

        long key = PairHash(x, y);
        long ret = value.ContainsKey(key) ? value[key] : 0;
        if (x > 1) {
            for (int i = 1; i < x; i++) {
                ret = Math.Max(ret, Dfs(i, y, value, memo) + Dfs(x - i, y, value, memo));
            }
        }
        if (y > 1) {
            for (int j = 1; j < y; j++) {
                ret = Math.Max(ret, Dfs(x, j, value, memo) + Dfs(x, y - j, value, memo));
            }
        }
        memo[x, y] = ret;
        return ret;
    }

    public long PairHash(int x, int y) {
        return ((long)x << 16) ^ y;
    }
    
}