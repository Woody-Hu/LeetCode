using System;

namespace LeetCode;

public class count_square_sum_triples
{
    public int CountTriples(int n)
    {
        var res = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                var sum = i * i + j * j;
                var sqrt = (int)Math.Sqrt(sum + 1.0);
                if (sqrt <= n && sqrt * sqrt == sum)
                {
                    res+=2;
                }
            }
        }
        
        return res;

    }
}