using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindAllAnagramsinaString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            InnerArray useParray = new InnerArray();
            HashSet<char> usePset = new HashSet<char>();
            foreach (var oneChar in p)
            {
                usePset.Add(oneChar);
                useParray.AddChar(oneChar);
            }

            int startIndex = 0;

            int useLength = s.Length;

            int pLength = p.Length;

            InnerArray tempArray = new InnerArray();

            List<int> returnValue = new List<int>();

            for (int endIndex = 0; endIndex < useLength; endIndex++)
            {
                if (!usePset.Contains(s[endIndex]))
                {
                    startIndex = endIndex + 1;
                    tempArray = new InnerArray();
                    continue;
                }

                tempArray.AddChar(s[endIndex]);

                if (pLength == endIndex - startIndex + 1)
                {
                    if (tempArray.ToString().Equals(useParray.ToString()))
                    {
                        returnValue.Add(startIndex);
                    }

                    tempArray.RemoveChar(s[startIndex]);
                    startIndex++;
                }

            }

            return returnValue;
        }

        class InnerArray
        {
            private int[] m_innerArray = new int[26];

            private string m_thisString = null;

            internal void AddChar(char inputChar)
            {
                m_innerArray[inputChar - 'a']++;
                m_thisString = null;
            }

            internal void RemoveChar(char inputChar)
            {
                m_innerArray[inputChar - 'a']--;
                m_thisString = null;
            }

            public override string ToString()
            {
                if (null == m_thisString)
                {
                    StringBuilder tempStringBuilder = new StringBuilder();

                    foreach (var oneValue in m_innerArray)
                    {
                        tempStringBuilder.Append(oneValue.ToString());
                    }

                    m_thisString = tempStringBuilder.ToString();
                }
                return m_thisString;
            }
        }
    }
}
