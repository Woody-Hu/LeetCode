namespace LeetCode;

public class lexicographically_smallest_string_after_a_swap
{
    public string GetSmallestString(string s)
    {
        var array = s.ToCharArray();
        for (int i = 0; i + 1 < array.Length; i++)
        {
            if (array[i] > array[i+1] && array[i] % 2 == array[i + 1] % 2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                break;
            }
        }

        return new string(array);

    }
}