namespace LeetCode;

public class substrings_of_size_three_with_distinct_characters
{
    public int CountGoodSubstrings(string s)
    {
        var res = 0;
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (s[i] != s[i + 1] && s[i] != s[i + 2] && s[i+1] != s[i + 2])
            {
                res++;
            }
        }

        return res;


    }
}