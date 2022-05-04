using System;
using System.Text;

namespace LeetCode
{
    public class remove_vowels_from_a_string
    {
        public string RemoveVowels(string s)
        {
            var stringBuilder = new StringBuilder(s.Length);
            foreach (var item in s)
            {
                if (item != 'a' && item != 'e' && item != 'i' && item != 'o' && item != 'u')
                {
                    stringBuilder.Append(item);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
