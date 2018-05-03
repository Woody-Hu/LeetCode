using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseStringII
    {
        public string ReverseStr(string s, int k)
        {
            var useChars = s.ToArray();

            for (int i = 0; i < useChars.Length; i += 2 * k)
            {
                int end = (i + k - 1) > (useChars.Length - 1) ? (useChars.Length - 1) : (i + k - 1);
                Reverse(useChars, i, end);
            }
            return new String(useChars);


        }

        private void Reverse(char[] inputChars,int startIndex,int endIndex)
        {
            while (startIndex < endIndex)
            {
                char temp = inputChars[startIndex];
                inputChars[startIndex] = inputChars[endIndex];
                inputChars[endIndex] = temp;
                ++startIndex; --endIndex;
            }
        }
    }
}
