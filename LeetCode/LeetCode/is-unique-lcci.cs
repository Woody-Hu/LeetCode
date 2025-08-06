namespace LeetCode;

public class is_unique_lcci
{
    public bool IsUnique(string astr)
    {
        var mask = 0;
        foreach (var c in astr)
        {
            var index = c - 'a';
            if ((mask & (1 << index)) != 0)
            {
                return false; 
            }
            mask |= (1 << index); 
        }
        
        return true;

    }
}