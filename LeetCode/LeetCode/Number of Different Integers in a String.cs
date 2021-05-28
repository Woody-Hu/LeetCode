using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Number_of_Different_Integers_in_a_String
    {
        public int NumDifferentIntegers(string word)
        {
            var set = new HashSet<string>();
            var current = new StringBuilder();
            foreach (var item in word)
            {
                if (!char.IsDigit(item))
                {
                    if (current.Length != 0)
                    {
                        set.Add(current.ToString().TrimStart('0'));
                    }

                    current = new StringBuilder();
                }
                else
                {
                    current.Append(item);
                }
            }

            if (current.Length != 0)
            {
                set.Add(current.ToString().TrimStart('0'));
            }

            return set.Count;
        }
    }
}
