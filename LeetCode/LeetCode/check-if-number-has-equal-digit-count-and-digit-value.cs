using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class check_if_number_has_equal_digit_count_and_digit_value
    {
        public bool DigitCount(string num)
        {
            var dic = new int[10];
            foreach (var item in num)
            {
                var value = item - '0';
                dic[value]++;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (dic[i] != (num[i] - '0'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
