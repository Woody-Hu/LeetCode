namespace LeetCode;

public class count_prefix_and_suffix_pairs_i
{
    public int CountPrefixSuffixPairs(string[] words) {
        var count = 0;
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = i + 1; j < words.Length; j++)
            {
                var left = words[i];
                var right = words[j];

                if (right.StartsWith(left) && right.EndsWith(left))
                {
                    count++;
                }
            }
        }
        
        return count;

    }
}