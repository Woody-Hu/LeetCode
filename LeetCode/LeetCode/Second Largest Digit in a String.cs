using System;
namespace LeetCode
{
    public class Second_Largest_Digit_in_a_String
    {
        public int SecondHighest(string s)
        {
            var res = -1;
            var max = -1;
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                {
                    continue;
                }

                var value = item - '0';
                if (value > max)
                {
                    res = max;
                    max = value;
                }
                else if (value > res && value < max)
                {
                    res = value;
                }
            }

            return res;
        }
    }
}
