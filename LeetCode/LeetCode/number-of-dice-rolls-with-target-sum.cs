namespace LeetCode;

public class number_of_dice_rolls_with_target_sum
{
    const int MOD = 1000000007;

    public int NumRollsToTarget(int n, int k, int target) {
        int[] f = new int[target + 1];
        f[0] = 1;
        for (int i = 1; i <= n; ++i) {
            for (int j = target; j >= 0; --j) {
                f[j] = 0;
                for (int x = 1; x <= k; ++x) {
                    if (j - x >= 0) {
                        f[j] = (f[j] + f[j - x]) % MOD;
                    }
                }
            }
        }
        return f[target];
    }
}