using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementMagicDictionary
    {
        Dictionary<string, List<int[]>> m_Dic = new Dictionary<string, List<int[]>>();

        /** Initialize your data structure here. */
        public ImplementMagicDictionary()
        {

        }

        /** Build a dictionary through a list of words */
        public void BuildDict(string[] dict)
        {
            foreach (var oneString in dict)
            {
               
                for (int i = 0; i <= oneString.Length - 1; i++)
                {
                    string useString = oneString.Substring(0, i) + oneString.Substring(i+1) ;

                    if (!m_Dic.ContainsKey(useString))
                    {
                        m_Dic.Add(useString, new List<int[]>());
                    }

                    m_Dic[useString].Add(new int[]{i, oneString[i]});

                }
            }
        }

        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
        public bool Search(string word)
        {
           

            for (int i = 0; i <= word.Length - 1; i++)
            {
                string useString = word.Substring(0, i) + word.Substring(i + 1);

                if (m_Dic.ContainsKey(useString))
                {
                    foreach (var onePair in m_Dic[useString])
                    {
                        if (onePair[0] == i && onePair[1]!=word[i])
                        {
                            return true;
                        }
                    }
                }


            }
            return false;
        }
    }
}
