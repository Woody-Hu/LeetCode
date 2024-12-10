using System;
using System.Text;

namespace LeetCode;

public class calculate_digit_sum_of_a_string
{
    public string DigitSum(string s, int k) {
        while (s.Length > k)
        {
            var temp = new StringBuilder();
            var n = s.Length;
            for (int i = 0; i < n; i += k)
            {
                var sum = 0;
                for (int j = i; j < Math.Min(i + k, n); j++)
                {
                    sum += s[j] - '0';
                }
                
                temp.Append(sum);
            }
            
            s = temp.ToString();
        }
        
        return s;
    }
}