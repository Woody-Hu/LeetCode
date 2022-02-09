using System;
namespace LeetCode
{
    public class Minimum_Sum_of_Four_Digit_Number_After_Splitting_Digits
    {
        public int MinimumSum(int num)
        {
            var values = new int[4];
            var current = 0;
            while (num > 0) 
            {
                values[current++] = num % 10;
                num /= 10;
            }

            Array.Sort(values);
            return values[0] * 10 + values[2] + values[1] * 10 + values[3];
        }
    }
}
