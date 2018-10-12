using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class ShortestCompletingWord
    {
        public string ShortestCompletingWordMethod(string licensePlate, string[] words)
        {
            Dictionary<char, int> useCharDic = new Dictionary<char, int>();

            foreach (var oneChar in licensePlate)
            {
                if (Char.IsLetter(oneChar))
                {
                    useCharDic[char.ToLower(oneChar)] = useCharDic.GetValueOrDefault(char.ToLower(oneChar)) + 1;
                }
            }

            string returnValue = null;

            foreach (var oneWord in words)
            {
                var tempDic = oneWord.GroupBy(k => k).ToDictionary(k => k.Key, k => k.Count());

                bool ifCanUse = true;

                foreach (var oneKVP in useCharDic)
                {
                    if (!tempDic.ContainsKey(oneKVP.Key) || tempDic[oneKVP.Key] < oneKVP.Value)
                    {
                        ifCanUse = false;
                        break;
                    }
                }

                if (ifCanUse)
                {
                    returnValue = null == returnValue ? oneWord :
                        oneWord.Length < returnValue.Length ? oneWord : returnValue;
                }
            }

            return returnValue;
        }
    }
}
