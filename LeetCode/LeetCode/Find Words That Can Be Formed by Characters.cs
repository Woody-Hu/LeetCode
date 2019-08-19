using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Find_Words_That_Can_Be_Formed_by_Characters
    {
        public int CountCharacters(string[] words, string chars)
        {
            var array = new int[26];
            var res = 0;
            foreach (var oneChar in chars)
            {
                array[oneChar - 'a']++;
            }

            foreach (var oneWord in words)
            {
                var index = 0;
                var tag = true;
                for (; index < oneWord.Length && tag; index++)
                {
                    if (--array[oneWord[index] - 'a'] < 0)
                    {
                        tag = false;
                        break;
                    }
                }

                if (index == oneWord.Length)
                {
                    res += oneWord.Length;
                    index = oneWord.Length - 1;
                }

                for (; index>=0; index--)
                {
                    array[oneWord[index] - 'a']++;
                }
            }

            return res;
        }
    }
}
