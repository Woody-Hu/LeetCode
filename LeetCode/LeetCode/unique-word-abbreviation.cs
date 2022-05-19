using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class unique_word_abbreviation
    {
        public class ValidWordAbbr
        {
            private Dictionary<string, HashSet<string>> _abbreviations = new Dictionary<string, HashSet<string>>();

            public ValidWordAbbr(string[] dictionary)
            {
                foreach (var item in dictionary)
                {
                    var abbr = ToAbbr(item);
                    if (!_abbreviations.ContainsKey(abbr))
                    {
                        _abbreviations.Add(abbr, new HashSet<string>());
                    }

                    _abbreviations[abbr].Add(item);
                }
            }

            public bool IsUnique(string word)
            {
                var abbr = ToAbbr(word);
                if (!_abbreviations.TryGetValue(abbr, out var existSet))
                {
                    return true;
                }

                return existSet.Count == 1 && existSet.Contains(word);
            }

            private string ToAbbr(string input)
            {
                if (input.Length < 3)
                {
                    return input;
                }

                return $"{input[0]}{input.Length - 2}{input[input.Length - 1]}";
            }
        }
    }
}
