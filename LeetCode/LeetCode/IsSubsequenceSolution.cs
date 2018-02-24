using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            List<KeyValuePair<char, int>> lstCharKVP = new List<KeyValuePair<char, int>>();

            for (int tempIndex = 0; tempIndex < t.Length; tempIndex++)
            {
                lstCharKVP.Add(new KeyValuePair<char, int>(t[tempIndex], tempIndex));
            }

            var tempDic = lstCharKVP.GroupBy(k => k.Key).ToDictionary(k => k.Key, k => k.ToList());

            int lastIndex = -1;

            int tempIndexValue = 0;

            KeyValuePair<char, int> tempKVP;

            HashSet<int> usedSet = new HashSet<int>();

            foreach (var oneChar in s)
            {
                if (!tempDic.ContainsKey(oneChar) || tempDic[oneChar].Count == 0)
                {
                    return false;
                }
                else
                {
                    tempKVP = tempDic[oneChar].Find(k => (k.Value > lastIndex && !usedSet.Contains(k.Value)));

                    if (default(KeyValuePair<char, int>).Key == tempKVP.Key)
                    {
                        return false;
                    }

                    tempIndexValue = tempDic[oneChar].Find(k => k.Value > lastIndex).Value;
                    lastIndex = tempIndexValue;
                    usedSet.Add(tempIndexValue);
                }
            }

            return true;
        }
    }
}
