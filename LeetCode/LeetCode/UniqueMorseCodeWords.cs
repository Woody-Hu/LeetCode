using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] useValue = new string[] { ".-", "-...", "-.-.", "-..", ".",
                "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--",
                "-..-", "-.--", "--.." };

            HashSet<string> returnValue = new HashSet<string>();

            foreach (var oneWords in words)
            {
                StringBuilder tempStringBuilder = new StringBuilder();

                foreach (var oneChar in oneWords)
                {
                    tempStringBuilder.Append(useValue[oneChar - 'a']);
                }
                returnValue.Add(tempStringBuilder.ToString());
            }

            return returnValue.Count;
        }
    }
}
