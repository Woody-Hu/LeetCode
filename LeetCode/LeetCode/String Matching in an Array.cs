using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class String_Matching_in_an_Array
    {
        public IList<string> StringMatching(string[] words)
        {
            HashSet<string> answer = new HashSet<string>();

            for (var i = 0; i < words.Length; i++)
            {
                for (var j = 0; j < words.Length; j++)
                {
                    if (answer.Contains(words[i]))
                    {
                        continue;
                    }

                    if (i != j)
                    {
                        if (words[j].Contains(words[i]))
                        {
                            answer.Add(words[i]);
                        }

                    }
                }
            }
            return answer.ToList();
        }
    }
}
