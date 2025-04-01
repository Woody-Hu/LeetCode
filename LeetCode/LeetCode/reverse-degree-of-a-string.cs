namespace LeetCode;

public class reverse_degree_of_a_string
{
    public int ReverseDegree(string s) {
        var res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            res += ('{' - s[i]) * (i + 1);
        }
        
        return res;

    }
}