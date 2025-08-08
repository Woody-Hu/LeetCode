namespace LeetCode;

public class check_if_strings_can_be_made_equal_with_operations_i
{
    public bool CanBeEqual(string s1, string s2)
    {
        return CanBeEqualInternal(s1, s2, 0, 2) && CanBeEqualInternal(s1, s2, 1, 3);

    }

    public bool CanBeEqualInternal(string s1, string s2, int index1, int index2)
    {
        return (s1[index1] == s2[index1] && s1[index2] == s2[index2]) ||
               (s1[index1] == s2[index2] && s1[index2] == s2[index1]);
    }
}