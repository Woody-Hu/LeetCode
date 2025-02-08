using System;

namespace LeetCode;

public class number_of_ways_to_earn_points
{
    public int WaysToReachTarget(int target, int[][] types) {
        const int mod = 1000000007;
        var f = new int[target + 1];
        f[0] = 1;
        foreach (var type in types) {
            var count = type[0];
            var marks = type[1];
            for (int j = target; j >0; --j) {
                for (int k = 1; k <= Math.Min(count,j/marks); ++k) {
                    f[j] = (f[j] + f[j - k * marks]) % mod;
                }
            }
        }
        
        return f[target];
    }
}