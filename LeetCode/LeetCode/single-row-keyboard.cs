using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class single_row_keyboard
	{
		public int CalculateTime(string keyboard, string word)
		{
			var chars = new Dictionary<char, int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
				chars[keyboard[i]] = i;
            }

			var res = 0;
			var currentIndex = 0;
            for (int i = 0; i < word.Length; i++)
            {
				var i1 = chars[word[i]];
				res += Math.Abs(currentIndex - i1);
				currentIndex = i1;
            }

			return res;
		}
	}
}

