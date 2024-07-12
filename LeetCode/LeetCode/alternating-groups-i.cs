namespace LeetCode;

public class alternating_groups_i
{
    public int NumberOfAlternatingGroups(int[] colors) {
        var res = 0;
        var n = colors.Length;
        for (int i = 0; i < n; i++)
        {
            if (colors[i] != colors[(i+1)%n] && colors[(i+1)%n] != colors[(i+2)%n])
            {
                res++;
            }
        }
        
        return res;
    }
}