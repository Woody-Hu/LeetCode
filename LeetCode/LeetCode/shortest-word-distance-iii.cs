using System;
namespace LeetCode
{
    public class shortest_word_distance_iii
    {
        public int ShortestWordDistance(string[] wordsDict, string word1, string word2)
        {
            var lastId = -1;
            var res = int.MaxValue;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i].Equals(word1) || wordsDict[i].Equals(word2))
                {
                    if (lastId != -1 && (!wordsDict[i].Equals(wordsDict[lastId]) ||word1.Equals(word2) ))
                    {
                        res = Math.Min(res, i - lastId);
                    }

                    lastId = i;
                }
            }

            return res;
        }
    }
}
