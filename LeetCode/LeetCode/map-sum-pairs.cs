using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MapSum
    {
        private Dictionary<string, int> _dictionary;
        private Dictionary<string, int> _prefixDictionary;

        public MapSum()
        {
            _dictionary = new Dictionary<string, int>();
            _prefixDictionary = new Dictionary<string, int>();
        }

        public void Insert(string key, int val)
        {
            int delta = val;
            if (_dictionary.ContainsKey(key))
            {
                delta -= _dictionary[key];
                _dictionary[key] = val;
            }
            else
            {
                _dictionary.Add(key, val);
            }
            for (int i = 1; i <= key.Length; ++i)
            {
                string currprefix = key.Substring(0, i);
                if (_prefixDictionary.ContainsKey(currprefix))
                {
                    _prefixDictionary[currprefix] += delta;
                }
                else
                {
                    _prefixDictionary.Add(currprefix, delta);
                }
            }
        }

        public int Sum(string prefix)
        {
            return _prefixDictionary.ContainsKey(prefix) ? _prefixDictionary[prefix] : 0;
        }
    }
}
