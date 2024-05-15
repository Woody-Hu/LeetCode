namespace LeetCode;

public class minimum_number_of_pushes_to_type_word_i
{
    public int MinimumPushes(string word) {
        var n = word.Length;
        var k = n / 8;
        return (k * 4 + n % 8) * (k + 1);

    }
}