namespace LeetCode;

public class largest_number_after_digit_swaps_by_parity
{
    public int LargestInteger(int num) {
        var s = num.ToString().ToCharArray();
        var n = s.Length;
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (s[i] < s[j] && ((s[i] - '0') % 2 == 0) == ((s[j] - '0') % 2 == 0))
                {
                    (s[i], s[j]) = (s[j], s[i]);
                }
            }
        }
        
        return int.Parse(new string(s));
    }
}