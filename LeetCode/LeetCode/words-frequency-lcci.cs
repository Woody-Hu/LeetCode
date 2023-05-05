using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class words_frequency_lcci
	{
        public class WordsFrequency
        {
            private readonly Dictionary<string, int> _dic = new Dictionary<string, int>();

            public WordsFrequency(string[] book)
            {
                foreach (var item in book)
                {
                    if (!_dic.ContainsKey(item))
                    {
                        _dic.Add(item, 0);
                    }

                    _dic[item]++;
                }
            }

            public int Get(string word)
            {
                if (_dic.TryGetValue(word, out var exist))
                {
                    return exist;
                }

                return 0;
            }
        }
    }
}

