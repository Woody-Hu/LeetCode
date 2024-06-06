namespace LeetCode;

public class check_if_all_as_appears_before_all_bs
{
    public bool CheckString(string s) {
        var lastA = -1;
        var firstB = -1;
        for (var i = 0; i < s.Length; i++) {
            if (s[i] == 'a') {
                lastA = i;
            } else if (s[i] == 'b') {
                if (firstB == -1) {
                    firstB = i;
                }
            }
        }
        
        return firstB == -1 || lastA < firstB;

    }
}