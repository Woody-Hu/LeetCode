using System;

namespace LeetCode;

public class minimum_cost_to_cut_a_stick
{
    public int MinCost(int n, int[] cuts) {
        int m = cuts.Length;
        Array.Sort(cuts);
        int[] newCuts = new int[m + 2];
        newCuts[0] = 0;
        for (int i = 1; i <= m; ++i) {
            newCuts[i] = cuts[i - 1];
        }
        newCuts[m + 1] = n;
        int[,] f = new int[m + 2, m + 2];
        for (int i = m; i >= 1; --i) {
            for (int j = i; j <= m; ++j) {
                f[i, j] = (i == j) ? 0 : int.MaxValue;
                for (int k = i; k <= j; ++k) {
                    f[i, j] = Math.Min(f[i, j], f[i, k - 1] + f[k + 1, j]);
                }
                f[i, j] += newCuts[j + 1] - newCuts[i - 1];
            }
        }
        
        return f[1, m];
    }
}