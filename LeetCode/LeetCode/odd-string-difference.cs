using System.Linq;

namespace LeetCode;

public class odd_string_difference
{
    public string OddString(string[] words) {
        int[] diff0 = Get(words[0]);
        int[] diff1 = Get(words[1]);
        if (Enumerable.SequenceEqual(diff0, diff1)) {
            for (int i = 2; i < words.Length; i++) {
                if (!Enumerable.SequenceEqual(diff0, Get(words[i]))) {
                    return words[i];
                }
            }
        }
        return Enumerable.SequenceEqual(diff0, Get(words[2])) ? words[1] : words[0];
    }

    private int[] Get(string word) {
        int[] diff = new int[word.Length - 1];
        for (int i = 0; i + 1 < word.Length; i++) {
            diff[i] = word[i + 1] - word[i];
        }
        return diff;
    }
}