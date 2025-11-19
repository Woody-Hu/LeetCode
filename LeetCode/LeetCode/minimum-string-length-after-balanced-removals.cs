using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_string_length_after_balanced_removals
    {
        public int MinLengthAfterRemovals(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count > 0 && c != stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count;


        }
    }
}
