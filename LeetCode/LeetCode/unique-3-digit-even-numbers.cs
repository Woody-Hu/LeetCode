using System.Collections.Generic;

namespace LeetCode;

public class unique_3_digit_even_numbers
{
    public int TotalNumbers(int[] digits)
    {
        var set = new HashSet<int>();
        var n = digits.Length;
        for (int i = 0; i < n; i++)
        {
            int a = digits[i];
            if (a % 2 > 0) {
                continue;
            }
            
            for (int j = 0; j < n; j++)
            {
                if (j == i) {
                    continue;
                }
                
                for (int k = 0; k < n; k++)
                {
                    int c = digits[k];
                    if (c == 0 || k == i || k == j) {
                        continue;
                    }
                    
                    set.Add(c * 100 + digits[j] * 10 + a);
                }
            }
        }

        return set.Count;

    }
}