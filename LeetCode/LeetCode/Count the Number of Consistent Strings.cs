using System;
using System.Collections;

namespace LeetCode
{
    public class Count_the_Number_of_Consistent_Strings
    {
        public Count_the_Number_of_Consistent_Strings()
        {
        }

        public int CountConsistentStrings(string allowed, string[] words)
        {
            var bitArray = new BitArray(26, false);
            foreach (var item in allowed)
            {
                var index = item - 'a';
                bitArray[index] = true;
            }

            var res = 0;
            var consistent = true;
            foreach (var oneWord in words)
            {
                consistent = true;
                foreach (var oneChar in oneWord)
                {
                    var i = oneChar - 'a';
                    if (!bitArray[i])
                    {
                        consistent = false;
                        break;
                    }
                }

                if (consistent)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
