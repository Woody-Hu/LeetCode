using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NumberofMatchingSubsequences
    {
        public int NumMatchingSubseq(string S, string[] words)
        {
            List<int>[] useIndexes = new List<int>[26];

            for (int i = 0; i < 26; i++)
            {
                useIndexes[i] = new List<int>();
            }

            int tempStrIndex = 0;

            foreach (var oneChar in S)
            {
                int tempIndex = oneChar - 'a';
                useIndexes[tempIndex].Add(tempStrIndex);
                tempStrIndex++;
            }

            bool continueTag = false;

            int lastUseIndex = -1;

            int returnValue = 0;

            foreach (var oneWord in words)
            {
                continueTag = false;
                lastUseIndex = -1;
                List<int>[] tempuseIndexes = new List<int>[26];

                for (int i = 0; i < 26; i++)
                {
                    tempuseIndexes[i] = new List<int>();
                }

                foreach (var oneChar in oneWord)
                {
                    int tempIndex = oneChar - 'a';

                    if (tempuseIndexes[tempIndex].Count == useIndexes[tempIndex].Count || useIndexes[tempIndex][useIndexes[tempIndex].Count - 1] <= lastUseIndex)
                    {
                        continueTag = true;
                        break;
                    }

                    int tempNowUseIndex = (from n in useIndexes[tempIndex] where n > lastUseIndex select n ).First();

                    if (tempNowUseIndex <= lastUseIndex)
                    {
                        continueTag = true;
                        break;
                    }

                    tempuseIndexes[tempIndex].Add(tempNowUseIndex);

                    lastUseIndex = tempNowUseIndex;
                }

                if (continueTag)
                {
                    continue;
                }

                returnValue++;
            }

            return returnValue;


        }
    }
}
