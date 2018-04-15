using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaximumProductofWordLengths
    {
        public int MaxProduct(string[] words)
        {
            int returnValue = 0;

            int wordLength = words.Length;

            int[] bitValues = new int[wordLength];

            for (int i = 0; i < wordLength; i++)
            {
                bitValues[i] = 0;

                foreach (var oneChar in words[i])
                {
                    bitValues[i] |= 1 << (oneChar - 'a');
                }
            }

            for (int i = 0; i < wordLength; i++)
            {
                for (int j = i + 1; j < wordLength; j++)
                {
                    if ((bitValues[i] & bitValues[j]) == 0)
                    {
                        returnValue = Math.Max(returnValue, words[i].Length * words[j].Length);
                    }
                }
            }

            return returnValue;
        }
    }
}
