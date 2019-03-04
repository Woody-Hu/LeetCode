using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Common_Characters
    {
        public IList<string> CommonChars(string[] A)
        {
            var arrays = new int[A.Length][];

            for (int i = 0; i < A.Length; i++)
            {
                arrays[i] = new int[26];
            }

            var index = 0;

            foreach (var oneString in A)
            {
                foreach (var oneChar in oneString)
                {
                    arrays[index][oneChar - 'a']++;
                }

                index++;
            }

            var list = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                var count = arrays[0][i];
                if (count == 0)
                {
                    continue;
                }

                for (int j = 0; j < arrays.Length; j++)
                {
                    count = Math.Min(count, arrays[j][i]);
                }

                if (count != 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        list.Add(((char)(i + 'a')).ToString());
                    }
                }
            }

            return list;
        }
    }
}
