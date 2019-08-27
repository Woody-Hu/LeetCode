using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Validate_Stack_Sequences
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            if (pushed == null || popped == null || pushed.Length != popped.Length) return false;
            var s = new Stack<int>();
            int i = 0, j = 0;
            while (i < pushed.Length && j < popped.Length)
            {
                if (s.Count == 0 || !s.Peek().Equals(popped[j]))
                {
                    s.Push(pushed[i]);
                    i++;
                }
                else
                {
                    s.Pop();
                    j++;
                }
            }

            while (j < popped.Length && s.Count != 0 && s.Peek().Equals(popped[j]))
            {
                s.Pop();
                j++;
            }

            return (s.Count == 0 && j == popped.Length);
        }
    }
}
