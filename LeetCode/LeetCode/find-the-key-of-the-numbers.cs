using System;

namespace LeetCode;

public class find_the_key_of_the_numbers
{
    public int GenerateKey(int num1, int num2, int num3)
    {
        var res = 0;
        for (var k = 1; num1 > 0 && num2 > 0 && num3 > 0; k*=10)
        {
            res += Math.Min(Math.Min(num1 % 10, num2 % 10), num3 % 10) * k;
            num1 /= 10;
            num2 /= 10;
            num3 /= 10;
        }
        
        return res;

    }
}