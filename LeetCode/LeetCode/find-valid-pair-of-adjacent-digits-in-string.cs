namespace LeetCode;

public class find_valid_pair_of_adjacent_digits_in_string
{
    public string FindValidPair(string s)
    {
        var array = s.ToCharArray();
        var cnt = new int[10];
        foreach (var c in s)
        {
            cnt[c - '0']++;
        }
        
        for (var i = 1; i < s.Length; i++)
        {
            int x = s[i - 1] - '0';
            int y = s[i] - '0';
            if (x != y && cnt[x] == x && cnt[y] == y) {
                return s.Substring(i - 1,  2);
            }
        }
        
        return "";
    }
}