using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Remove_Duplicate_Letters
    {
        public string RemoveDuplicateLetters(string s)
        {
            var chars = new int[26];
            var visit = new bool[26];
            foreach (var item in s)
            {
                chars[item - 'a']++;
            }

            var stack = new Stack<char>();
            foreach (var item in s)
            {
                var i = item - 'a';
                chars[i]--;
                if (visit[i])
                {
                    continue;
                }

                while (stack.Any() && item < stack.Peek() && chars[stack.Peek() - 'a'] > 0)
                {
                    visit[stack.Pop() - 'a'] = false;
                }

                stack.Push(item);
                visit[i] = true;
            }

            var stringBuilder = new StringBuilder();
            while (stack.Any())
            {
                stringBuilder.Insert(0, stack.Pop());
            }

            return stringBuilder.ToString();
        }
    }
}
