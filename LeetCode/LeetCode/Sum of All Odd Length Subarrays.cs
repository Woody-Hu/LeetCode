using System;
namespace LeetCode
{
    public class Sum_of_All_Odd_Length_Subarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            var sum = 0;
            for (var i = 0; i < arr.Length; i++)
                sum += (arr[i] * ((((i + 1) * (arr.Length - i)) + 1) / 2));
            return sum;
        }
    }
}
