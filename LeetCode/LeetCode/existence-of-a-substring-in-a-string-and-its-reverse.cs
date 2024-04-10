namespace LeetCode;

public class existence_of_a_substring_in_a_string_and_its_reverse
{
    public bool IsSubstringPresent(string s) {
        var array = s.ToCharArray();
        var visited = new bool[26][];
        for (int i = 0; i < 26; i++) {
            visited[i] = new bool[26];
        }

        for (int i = 1; i < s.Length; i++)
        {
            var x = s[i - 1] - 'a';
            var y = s[i] - 'a';
            visited[x][y] = true;
            if (visited[y][x])
            {
                return true;
            }
        }
        
        return false;
    }
}