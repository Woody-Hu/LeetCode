namespace LeetCode;

public class trim_trailing_vowels
{
    public string TrimTrailingVowels(string s) {
        int end = s.Length - 1;
        while (end >= 0 && IsVowel(s[end])) {
            end--;
        }
        return s.Substring(0, end + 1);
    }

    private bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
    
}