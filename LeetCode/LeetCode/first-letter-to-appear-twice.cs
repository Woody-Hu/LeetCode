using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class first_letter_to_appear_twice
    {
        public char RepeatedCharacter(string s)
        {
            var set = new HashSet<char>();
            foreach (var item in s)
            {
                if (set.Contains(item))
                {
                    return item;
                }

                set.Add(item);
            }

            return ' ';
        }
    }
}
