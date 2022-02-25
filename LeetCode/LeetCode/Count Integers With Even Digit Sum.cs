using System;
namespace LeetCode
{
    public class Count_Integers_With_Even_Digit_Sum
    {
        public int CountEven(int num)
        {
            int sum = num % 10 + (num / 10) % 10 + (num / 100) % 10 + (num / 1000) % 10;
            return (num - (sum & 1)) / 2;
        }
    }
}
