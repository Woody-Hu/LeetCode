using System;

namespace LeetCode;

public class minimum_steps_to_convert_string_with_operations
{
    public int MinOperations(string S, string T) {
        char[] s = S.ToCharArray();
        char[] t = T.ToCharArray();
        int n = s.Length;

        int[][] revOp = new int[n][];
        for (int i = 0; i < n; i++) {
            revOp[i] = new int[n];
        }

        for (int i = 0; i < 2 * n - 1; i++) {
            int[][] cnt = new int[26][];
            for (int j = 0; j < 26; j++) {
                cnt[j] = new int[26];
            }
            int op = 1;
            int l = i / 2;
            int r = (i + 1) / 2;
            while (l >= 0 && r < n) {
                Update(s[l], t[r], cnt, ref op);
                if (l != r) {
                    Update(s[r], t[l], cnt, ref op);
                }
                revOp[l][r] = op;
                l--;
                r++;
            }
        }

        int[] f = new int[n + 1];
        for (int i = 0; i < n; i++) {
            int res = int.MaxValue;
            int[][] cnt = new int[26][];
            for (int j = 0; j < 26; j++) {
                cnt[j] = new int[26];
            }
            int op = 0;
            for (int j = i; j >= 0; j--) {
                Update(s[j], t[j], cnt, ref op);
                res = Math.Min(res, f[j] + Math.Min(op, revOp[j][i]));
            }
            f[i + 1] = res;
        }
        return f[n];
    }

    private void Update(char x, char y, int[][] cnt, ref int op) {
        if (x == y) {
            return;
        }
        int xi = x - 'a';
        int yi = y - 'a';
        if (cnt[yi][xi] > 0) {
            cnt[yi][xi]--;
        } else {
            cnt[xi][yi]++;
            op++;
        }
    }
}