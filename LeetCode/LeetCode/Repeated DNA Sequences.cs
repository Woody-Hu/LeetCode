using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Repeated_DNA_Sequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var dic = new Dictionary<string,int>();

            var length = s.Length - 9;

            for (int i = 0; i < length; i++)
            {
                var subString = s.Substring(i, 10);
                dic[subString] = dic.GetValueOrDefault(subString) + 1;
            }

            var list = new List<string>();

            foreach (var oneKVP in dic)
            {
                if (oneKVP.Value > 1)
                {
                    list.Add(oneKVP.Key);
                }
            }

            return list;

        }
    }
}
