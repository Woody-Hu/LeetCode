using System;
namespace LeetCode
{
    public class Largest_Odd_Number_in_String
    {
        public string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
                if (num[i] % 2 != 0) return num.Substring(0, i + 1);
            return string.Empty;
        }
    }
}
