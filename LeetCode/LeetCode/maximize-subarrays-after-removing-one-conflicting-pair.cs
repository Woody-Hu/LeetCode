using System;

namespace LeetCode;

public class maximize_subarrays_after_removing_one_conflicting_pair
{
    public long MaxSubarrays(int n, int[][] conflictingPairs) {
        int[] bMin1 = new int[n + 1];
        int[] bMin2 = new int[n + 1];
        Array.Fill(bMin1, int.MaxValue);
        Array.Fill(bMin2, int.MaxValue);
        foreach (var pair in conflictingPairs) {
            int a = Math.Min(pair[0], pair[1]);
            int b = Math.Max(pair[0], pair[1]);
            if (bMin1[a] > b) {
                bMin2[a] = bMin1[a];
                bMin1[a] = b;
            } else if (bMin2[a] > b) {
                bMin2[a] = b;
            }
        }
        long res = 0;
        int ib1 = n, b2 = int.MaxValue;
        long[] delCount = new long[n + 1];
        for (int i = n; i >= 1; i--) {
            if (bMin1[ib1] > bMin1[i]) {
                b2 = Math.Min(b2, bMin1[ib1]);
                ib1 = i;
            } else {
                b2 = Math.Min(b2, bMin1[i]);
            }
            res += Math.Min(bMin1[ib1], n + 1) - i;
            delCount[ib1] += Math.Min(Math.Min(b2, bMin2[ib1]), n + 1) - Math.Min(bMin1[ib1], n + 1);
        }
        long max = 0;
        foreach (var val in delCount) {
            if (val > max) max = val;
        }
        return res + max;
    }
}