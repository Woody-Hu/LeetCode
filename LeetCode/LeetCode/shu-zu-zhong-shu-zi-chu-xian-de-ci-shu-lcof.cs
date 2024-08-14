namespace LeetCode;

public class shu_zu_zhong_shu_zi_chu_xian_de_ci_shu_lcof
{
    public int[] SockCollocation(int[] sockets)
    {
        var total = 0;
        foreach (var socket in sockets)
        {
            total ^= socket;
        }
        
        var div = 1;
        while ((div & total) == 0)
        {
            div <<= 1;
        }
        
        var a = 0;
        var b = 0;
        foreach (var socket in sockets)
        {
            if ((socket & div) == 0)
            {
                a ^= socket;
            }
            else
            {
                b ^= socket;
            }
        }
        
        return new[] {a, b};
    }
}