namespace LeetCode;

public class find_the_original_typed_string_i
{
    public int PossibleStringCount(string word)
    {
        var res = 1;
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i - 1] == word[i])
            {
                res++;
            }
        }

        return res;
    }
}