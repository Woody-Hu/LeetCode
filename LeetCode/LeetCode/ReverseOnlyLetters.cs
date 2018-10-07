using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReverseOnlyLetters
    {
        public string ReverseOnlyLettersMethod(string S)
        {
            char[] returnArray = new char[S.Length];

            int leftIndex = 0;
            int rightIndex = S.Length - 1;

            while (leftIndex <= rightIndex)
            {
                if (Char.IsLetter(S[leftIndex]) && Char.IsLetter(S[rightIndex]))
                {
                    returnArray[leftIndex] = S[rightIndex];
                    returnArray[rightIndex] = S[leftIndex];
                    leftIndex++;
                    rightIndex--;
                    continue;
                }

                if (!Char.IsLetter(S[leftIndex]))
                {
                    returnArray[leftIndex] = S[leftIndex];
                    leftIndex++;
                }

                if (!Char.IsLetter(S[rightIndex]))
                {
                    returnArray[rightIndex] = S[rightIndex];
                    rightIndex--;
                }
            }

            return new string(returnArray);
        }
    }
}
