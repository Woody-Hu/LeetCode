namespace LeetCode;

public class harshad_number
{
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        var sum = 0;
        var n = x;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        
        if (sum == 0)
        {
            return -1;
        }
        
        if (x % sum == 0)
        {
            return sum;
        }
        else
        {
            return -1;
        }

    }
}