namespace LeetCode;

public class separate_black_and_white_balls
{
    public long MinimumSteps(string s) {
        long ans = 0;
        int sum = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '1') {
                sum++;
            } else {
                ans += sum;
            }
        }
        
        return ans;
    }
}