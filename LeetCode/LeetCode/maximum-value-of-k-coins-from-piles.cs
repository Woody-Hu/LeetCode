using System;
using System.Collections.Generic;

namespace LeetCode;

public class maximum_value_of_k_coins_from_piles
{
    public int MaxValueOfCoins(IList<IList<int>> piles, int k) {
        int[] f = new int[k + 1];
        Array.Fill(f, -1);
        f[0] = 0;
        foreach (IList<int> pile in piles) {
            for (int i = k; i > 0; --i) {
                int value = 0;
                for (int t = 1; t <= pile.Count; ++t) {
                    value += pile[t - 1];
                    if (i >= t && f[i - t] != -1) {
                        f[i] = Math.Max(f[i], f[i - t] + value);
                    }
                }
            }
        }
        return f[k];
    }
}