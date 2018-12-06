using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var visitedSet = new HashSet<string>();
            var wordSet = wordList.ToHashSet();
            visitedSet.Add(beginWord);
            var distance = 1;

            while (!visitedSet.Contains(endWord))
            {
                var tempSet = new HashSet<string>();
                foreach (var oneString in visitedSet)
                {
                    for (var i = 0; i < oneString.Length; i++)
                    {
                        var chars = oneString.ToCharArray();

                        for (var j = 'a'; j <= 'z'; j++)
                        {
                            chars[i] = j;
                            var tempString = new string(chars);
                            if (!wordSet.Contains(tempString)) continue;
                            tempSet.Add(tempString);
                            wordSet.Remove(tempString);
                        }
                    }
                }

                distance++;
                if (tempSet.Count == 0)
                {
                    return 0;
                }

                visitedSet = tempSet;
            }

            return distance;
        }
    }
}
