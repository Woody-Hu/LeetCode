using System;
namespace LeetCode
{
    public class Reverse_Prefix_of_Word
    {
        public string ReversePrefix(string word, char ch)
        {
            var i = word.IndexOf(ch);
            if (i < 0)
            {
                return word;
            }

            var array = new char[word.Length];
            var j = 0;
            for (; i >= 0; i--, j++)
            {
                array[j] = word[i];

            }

            for (; j < word.Length; j++)
            {
                array[j] = word[j];
            }

            return new string(array);
        }
    }
}
