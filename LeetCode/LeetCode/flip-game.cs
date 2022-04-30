using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class flip_game
	{
		public IList<string> GeneratePossibleNextMoves(string currentState)
		{
			var res = new List<string>();
			var array = currentState.ToCharArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == '+' && array[i + 1] == '+')
                {
					array[i] = '-';
					array[i + 1] = '-';
					res.Add(new string(array));
					array[i] = '+';
					array[i + 1] = '+';
				}
            }

			return res;
		}
	}
}

