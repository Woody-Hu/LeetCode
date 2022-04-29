using System;
namespace LeetCode
{
    public class shortest_word_distance
    {
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            var p1 = -1;
            var p2 = -1;
            var res = int.MaxValue;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    p1 = i;
                }

                if (wordsDict[i] == word2)
                {
                    p2 = i;
                }

                if (p1 != -1 && p2 != -1)
                {
                    res = Math.Min(res, Math.Abs(p2 - p1));
                }
            }

            return res;
        }
    }
}
