using System;
namespace LeetCode
{
	public class check_if_two_string_arrays_are_equivalent
	{
		public bool ArrayStringsAreEqual(string[] word1, string[] word2)
		{
			var s1 = string.Concat(word1);
			var s2 = string.Concat(word2);
			return s1.Equals(s2);
		}
	}
}

