using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            StringBuilder[] useStringBuilderArray = new StringBuilder[numRows];

            for (int i = 0; i < numRows; i++)
            {
                useStringBuilderArray[i] = new StringBuilder();
            }

            int tempCharIndex = 0;

            var tempLength = s.Length;

            while (tempCharIndex < tempLength)
            {
                for (int i = 0; i < numRows && tempCharIndex < tempLength; i++)
                {
                    useStringBuilderArray[i].Append(s[tempCharIndex++]);
                }

                for (int i = numRows - 2; i > 0 && tempCharIndex < tempLength; i--)
                {
                    useStringBuilderArray[i].Append(s[tempCharIndex++]);
                }
            }

            StringBuilder returnValue = new StringBuilder();

            foreach (var oneValue in useStringBuilderArray)
            {
                returnValue.Append(oneValue.ToString());
            }

            return returnValue.ToString();
        }
    }
}
