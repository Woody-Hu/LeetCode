using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class verify_preorder_sequence_in_binary_search_tree
	{
		public bool VerifyPreorder(int[] preorder)
		{
			var stack = new Stack<int>();
			var lastMin = int.MinValue;
            foreach (var item in preorder)
            {
                if (item < lastMin)
                {
					return false;
                }

                while (stack.Count != 0 && stack.Peek() < item)
                {
					lastMin = stack.Pop();
                }

				stack.Push(item);
            }

			return true;
		}
	}
}

