using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Sort_Characters_By_Frequency
    {
        public string FrequencySort(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var oneChar in s)
            {
                dict[oneChar] = dict.GetValueOrDefault(oneChar) + 1;
            }

            var list = dict.ToList();
            list.Sort(new KeyValueComparer());

            var stringBuilder = new StringBuilder();
            foreach (var onePair in list)
            {
                for (int i = 1; i <= onePair.Value; i++)
                {
                    stringBuilder.Append(onePair.Key);
                }
            }

            return stringBuilder.ToString();
        }

        private class KeyValueComparer : IComparer<KeyValuePair<char, int>>
        {
            public int Compare(KeyValuePair<char, int> x, KeyValuePair<char, int> y)
            {
                return y.Value - x.Value;
            }
        }
    }
}
