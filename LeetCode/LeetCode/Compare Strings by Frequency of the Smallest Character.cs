using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Compare_Strings_by_Frequency_of_the_Smallest_Character
    {
        private int[] _array = new int[26];

        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var queriesCount = new int[queries.Length];
            var wordsCount = new int[words.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                queriesCount[i] = NumSmallerByFrequency(queries[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                wordsCount[i] = NumSmallerByFrequency(words[i]);
            }

            Array.Sort(wordsCount);
            var res = new int[queries.Length];
            for (int i = 0; i < queriesCount.Length; i++)
            {
                int l = 0, r = wordsCount.Length - 1;
                while (l <= r)
                {
                    int mid = (l + r) / 2;
                    if (wordsCount[mid] <= queriesCount[i])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
                res[i] = wordsCount.Length - l;
            }
            return res;

        }

        private int NumSmallerByFrequency(string word)
        {
            for (int i = 0; i < 26; i++)
            {
                _array[i] = 0;
            }

            foreach (var oneChar in word)
            {
                _array[oneChar - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (_array[i] != 0)
                {
                    return _array[i];
                }
            }

            return 0;
        }
    }
}
