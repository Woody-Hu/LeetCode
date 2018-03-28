using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestUncommonSubsequenceII
    {
        public int FindLUSlength(string[] strs)
        {
            if (0 == strs.Count())
            {
                return -1;
            }

            var tempList = strs.Distinct().GroupBy(k => k.Length).OrderBy(k => -k.Key);

            HashSet<string> notUse = new HashSet<string>();
            HashSet<string> visit = new HashSet<string>();

            foreach (var oneStr in strs)
            {
                if (visit.Contains(oneStr))
                {
                    notUse.Add(oneStr);
                }
                visit.Add(oneStr);
            }

            for (int i = 0; i < tempList.Count(); i++)
            {
                foreach (var oneString in tempList.ElementAt(i))
                {
                    bool hasSubSequence = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        foreach (var oneLargString in tempList.ElementAt(j))
                        {
                            hasSubSequence = isSubSequence(oneString, oneLargString);

                            if (hasSubSequence)
                            {
                                break;
                            }
                        }
                    }

                    if (!hasSubSequence && !notUse.Contains(oneString))
                    {
                        return tempList.ElementAt(i).Key;
                    }
                }
            }

            return -1;

            

        }

        private bool isSubSequence(string inputShort,string inputLarg)
        {
            int shortIndex = 0;

            int largIndex = 0;

            while (shortIndex < inputShort.Length && largIndex < inputLarg.Length)
            {
                if (inputShort[shortIndex] == inputLarg[largIndex])
                {
                    shortIndex++;
                }
                largIndex++;
            }

            return shortIndex == inputShort.Length;
        }
    }
}
