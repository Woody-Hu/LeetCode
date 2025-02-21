namespace LeetCode;

public class find_the_k_beauty_of_a_number
{
    public int DivisorSubstrings(int num, int k) {
        string s = num.ToString();   // num 十进制表示字符串
        int n = s.Length;
        int res = 0;
        for (int i = 0; i <= n - k; ++i) {
            // 枚举所有长度为 k 的子串
            int tmp = int.Parse(s.Substring(i, k));
            if (tmp != 0 && num % tmp == 0) {
                ++res;
            }
        }
        return res;
    }
}