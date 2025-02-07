namespace LeetCode;

public class fei_bo_na_qi_shu_lie_lcof
{
    public int Fib(int n) {
        const int MOD = 1000000007;
        if (n < 2) {
            return n;
        }
        int p = 0, q = 0, r = 1;
        for (int i = 2; i <= n; ++i) {
            p = q; 
            q = r; 
            r = (p + q) % MOD;
        }
        return r;
    }
}