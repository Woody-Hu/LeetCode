namespace LeetCode;

public class three_divisors
{
    public bool IsThree(int n)
    {
        var count = 0;
        var i = 1;
        while (i * i <= n)
        {
            if (n % i == 0)
            {
                if (i != n / i)
                {
                    count += 2;
                }
                else
                {
                    count++;
                }
            }
            
            i++;
        }

        return count == 3;
    }
}