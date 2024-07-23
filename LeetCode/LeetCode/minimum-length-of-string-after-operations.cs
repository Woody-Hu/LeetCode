namespace LeetCode;

public class minimum_length_of_string_after_operations
{
    public int MinimumLength(string s)
    {
        var array = new int[26];
        foreach (var item in s)
        {
            array[item - 'a']++;
        }

        var res = 0;
        foreach (var item in array)
        {
            res += (item - 1) % 2 + 1;
        }

        return res;
    }
}