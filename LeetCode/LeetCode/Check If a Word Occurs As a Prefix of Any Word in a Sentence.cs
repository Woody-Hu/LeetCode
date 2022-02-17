using System;
namespace LeetCode
{
    public class Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence
    {
        public Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence()
        {
        }

        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var array = sentence.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].StartsWith(searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
