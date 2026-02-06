using System.Text;

namespace LeetCode;

public class reverse_letters_then_special_characters_in_a_string
{
    public string ReverseByType(string s) {
        var letters = new StringBuilder();
        var specialCharacters = new StringBuilder();
        int length = s.Length;
        foreach (char c in s) {
            if (char.IsLetter(c)) {
                letters.Append(c);
            } else {
                specialCharacters.Append(c);
            }
        }
        
        var reversed = new StringBuilder();
        int j = letters.Length - 1, k = specialCharacters.Length - 1;
        foreach (char c in s) {
            if (char.IsLetter(c)) {
                reversed.Append(letters[j]);
                j--;
            } else {
                reversed.Append(specialCharacters[k]);
                k--;
            }
        }
        return reversed.ToString();
    }
    
}