namespace LeetCode;

public class WGki4K
{
    public int SingleNumber(int[] nums)
    {
        var a = 0;
        var b = 0;
        foreach (var num in nums)
        {
            b = (b ^ num) & ~a;
            a = (a ^ num) & ~b;
        }
        
        return b;
    }
}