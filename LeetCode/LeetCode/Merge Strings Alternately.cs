using System;
namespace LeetCode
{
    public class Merge_Strings_Alternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var length = word1.Length + word2.Length;
            var index1 = 0;
            var index2 = 0;
            var res = new char[length];
            var currentIndex = 0;
            while (index1 < word1.Length && index2 < word2.Length)
            {
                res[currentIndex++] = word1[index1++];
                res[currentIndex++] = word2[index2++];
            }

            if (index1 < word1.Length)
            {
                word1.CopyTo(index1, res, currentIndex, word1.Length - index1);
            }
            else if (index2 < word2.Length)
            {
                word2.CopyTo(index2, res, currentIndex, word2.Length - index2);
            }

            return new string(res);
        }
    }
}
