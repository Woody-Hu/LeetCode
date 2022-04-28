using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class group_shifted_strings
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var item in strings)
            {
                var key = GetStringIdentity(item);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }

                dict[key].Add(item);
            }

            var res = new List<IList<string>>();
            foreach (var item in dict)
            {
                res.Add(item.Value);
            }

            return res;
        }

        private string GetStringIdentity(string input)
        {
            var array = input.ToCharArray();
            var diff = array[0] - 'a';
            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i] - diff;
                if (current < 'a')
                {
                    current = current + 26;
                }

                array[i] = (char)current;
            }

            return new string(array);
        }
    }
}
