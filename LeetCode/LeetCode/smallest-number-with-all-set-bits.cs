namespace LeetCode;

public class smallest_number_with_all_set_bits
{
    public int SmallestNumber(int n)
    {
        var x = 1;
        while (x < n)
        {
            x = x * 2 + 1;
        }
        
        return x ;
    }
}