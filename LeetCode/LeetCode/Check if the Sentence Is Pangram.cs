using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Check_if_the_Sentence_Is_Pangram
    {
        public bool CheckIfPangram(string sentence)
        {
            var hashSet = new HashSet<char>(26);
            foreach (var item in sentence)
            {
                hashSet.Add(item);
            }

            return hashSet.Count == 26;
        }
    }
}
