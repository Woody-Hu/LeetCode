namespace LeetCode;

public class knight_dialer
{
    const int MOD = 1000000007;

    public int KnightDialer(int n) {
        int[][] original = {
            new int[]{0, 0, 0, 0, 1, 0, 1, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
            new int[]{0, 0, 0, 0, 1, 0, 0, 0, 1, 0},
            new int[]{1, 0, 0, 1, 0, 0, 0, 0, 0, 1},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{1, 1, 0, 0, 0, 0, 0, 1, 0, 0},
            new int[]{0, 0, 1, 0, 0, 0, 1, 0, 0, 0},
            new int[]{0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 1, 0, 1, 0, 0, 0, 0, 0}
        };
        int[][] res = {
            new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };

        int[][] original2 = new int[10][];
        for (int i = 0; i < 10; i++) {
            original2[i] = new int[10];
            original2[i][i] = 1;
        }
        n--;
        while (n > 0) {
            if ((n & 1) != 0) {
                original2 = Mul(original2, original);
            }
            original = Mul(original, original);
            n >>= 1;
        }
        res = Mul(res, original2);
        int ret = 0;
        foreach (int x in res[0]) {
            ret = (ret + x) % MOD;
        }

        return ret;
    }

    public int[][] Mul(int[][] lth, int[][] rth) {
        int[][] res = new int[lth.Length][];
        for (int i = 0; i < lth.Length; i++) {
            res[i] = new int[rth[0].Length];
        }
        for (int k = 0; k < lth[0].Length; k++) {
            for (int i = 0; i < lth.Length; i++) {
                for (int j = 0; j < rth[0].Length; j++) {
                    res[i][j] = (int) ((res[i][j] + 1L * lth[i][k] * rth[k][j] % MOD) % MOD);
                }
            }
        }
        return res;
    }
}