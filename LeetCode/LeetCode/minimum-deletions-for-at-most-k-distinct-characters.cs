using System.Collections.Generic;

namespace LeetCode;

public class minimum_deletions_for_at_most_k_distinct_characters
{
    public int MinDeletion(string s, int k) {
        int deletion = 0;
        IDictionary<char, int> counts = new Dictionary<char, int>();
        foreach (char c in s) {
            counts.TryAdd(c, 0);
            counts[c]++;
        }
        IList<int> countsList = new List<int>(counts.Values);
        ((List<int>) countsList).Sort((a, b) => a - b);
        for (int i = countsList.Count - k - 1; i >= 0; i--) {
            deletion += countsList[i];
        }
        return deletion;
    }
}