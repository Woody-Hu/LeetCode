using System;
namespace LeetCode
{
    public class Sum_of_Digits_of_String_After_Convert
    {
        public int GetLucky(string s, int k)
        {
            int res = 0;
            foreach (var item in s)
            {
                var value = item + 1 - 'a';
                if (value < 10)
                {
                    res += value;
                }
                else
                {
                    res += value / 10 + value % 10;
                }
            }

            k--;
            while (k-- > 0)
            {
                res = Calculate(res);
            }

            return res;
        }

        private int Calculate(int value)
        {
            int sum = 0;
            while (value > 0)
            {
                var temp = value % 10;
                sum = sum + temp;
                value = value / 10;
            }
            return sum;
        }
    }
}
