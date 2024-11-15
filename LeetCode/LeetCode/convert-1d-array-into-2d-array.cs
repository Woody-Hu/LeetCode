using System;

namespace LeetCode;

public class convert_1d_array_into_2d_array
{
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if (original.Length != m * n) {
            return new int[0][];
        }
        int[][] ans = new int[m][];
        for (int i = 0; i < m; ++i) {
            ans[i] = new int[n];
        }
        for (int i = 0; i < original.Length; i += n) {
            Array.Copy(original, i, ans[i / n], 0, n);
        }
        
        return ans;
    }
}