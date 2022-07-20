using System;
namespace LeetCode
{
    public class check_if_word_equals_summation_of_two_words
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            return (Calculate(firstWord) + Calculate(secondWord)) == Calculate(targetWord);
        }

        private int Calculate(string firstWord)
        {
            var res = 0;
            foreach (var item in firstWord)
            {
                res = res * 10;
                res += item - 'a';
            }

            return res;
        }
    }
}
