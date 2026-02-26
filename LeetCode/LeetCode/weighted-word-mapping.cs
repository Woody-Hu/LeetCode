using System.Text;

namespace LeetCode;

public class weighted_word_mapping
{
    public string MapWordWeights(string[] words, int[] weights) {
        StringBuilder sb = new StringBuilder();
        foreach (string word in words) {
            int sum = 0;
            foreach (char c in word) {
                sum += weights[c - 'a'];
            }
            int remainder = sum % 26;
            sb.Append((char) ('a' + (25 - remainder)));
        }
        return sb.ToString();
    }
}