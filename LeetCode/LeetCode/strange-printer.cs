using System;

namespace LeetCode;

public class strange_printer
{
    public int StrangePrinter(string s) {
        int n = s.Length;
        int[,] f = new int[n, n];
        for (int i = n - 1; i >= 0; i--) {
            f[i, i] = 1;
            for (int j = i + 1; j < n; j++) {
                if (s[i] == s[j]) {
                    f[i, j] = f[i, j - 1];
                } else {
                    int minn = int.MaxValue;
                    for (int k = i; k < j; k++) {
                        minn = Math.Min(minn, f[i, k] + f[k + 1, j]);
                    }
                    f[i, j] = minn;
                }
            }
        }
        return f[0, n - 1];
    }
}