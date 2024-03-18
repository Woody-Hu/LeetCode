using System;

namespace LeetCode;

public class find_the_sum_of_encrypted_integers
{
    public int SumOfEncryptedInt(int[] nums)
    {
        var res = 0;
        foreach (var item in nums)
        {
            var max = 0;
            var baseValue = 0;
            var temp = item;
            while (temp > 0)
            {
                max = Math.Max(max, temp % 10);
                baseValue = baseValue * 10 + 1;
                temp /= 10;
            }
            
            res += max * baseValue;
        }
        
        return res;

    }
}