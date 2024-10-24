namespace LeetCode;

public class minimum_moves_to_convert_string
{
    public int MinimumMoves(string s)
    {
        var covered = -1;
        var res = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'X' && i > covered)
            {
                res++;
                covered = i + 2;
            }
        }
        
        return res;

    }
}