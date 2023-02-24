using System;
namespace LeetCode
{
	public class swap_numbers_lcci
	{
        public int[] SwapNumbers(int[] numbers)
        {
            numbers[0] = numbers[0] ^ numbers[1];
            numbers[1] = numbers[0] ^ numbers[1];
            numbers[0] = numbers[0] ^ numbers[1];
            return numbers;
        }
    }
}

