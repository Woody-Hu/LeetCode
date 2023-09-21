using System;
namespace LeetCode
{
	public class remove_trailing_zeros_from_a_string
	{
        public string RemoveTrailingZeros(string num)
        {
            return num.TrimEnd('0');
        }
    }
}

