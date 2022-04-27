using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class shortest_word_distance_ii
    {
        private class WordDistance
        {
            private readonly Dictionary<string, List<int>> _locations = new Dictionary<string, List<int>>();

            public WordDistance(string[] wordsDict)
            {
                for (int i = 0; i < wordsDict.Length; i++)
                {
                    var value = wordsDict[i];
                    if (!_locations.ContainsKey(value))
                    {
                        _locations.Add(value, new List<int>());
                    }

                    _locations[value].Add(i);
                }
            }

            public int Shortest(string word1, string word2)
            {
                var location1s = _locations[word1];
                var location2s = _locations[word2];
                var li = 0;
                var ri = 0;
                var res = int.MaxValue;
                while (li < location1s.Count && ri < location2s.Count )
                {
                    var distance = Math.Abs(location1s[li] - location2s[ri]);
                    res = Math.Min(res, distance);
                    if (location1s[li] > location2s[ri])
                    {
                        ri++;
                    }
                    else
                    {
                        li++;
                    }
                }

                return res;
            }
        }

    }
}

