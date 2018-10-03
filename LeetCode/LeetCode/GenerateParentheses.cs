using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class GenerateParentheses
    {
        public GenerateParentheses()
        {
        }

        public IList<string> GenerateParenthesis(int n)
        {
            char[] userArray = new char[2*n];

            List<string> returnValue = new List<string>();

            InnerMethod(0, 0, 0, n, userArray, returnValue);

            return returnValue;
        }

        private void InnerMethod(int leftCount,int rightCount,int nowIndex,
                                 int length,char[] useArray,List<string> returnValue){
            if (rightCount == length)
            {
                returnValue.Add(new string(useArray));
            }

            if (leftCount < length)
            {
                useArray[nowIndex] = '(';
                InnerMethod(leftCount + 1, rightCount, nowIndex + 1, length, useArray, returnValue);
                    
            }

            if (rightCount<leftCount)
            {
                useArray[nowIndex] = ')';
                InnerMethod(leftCount, rightCount + 1, nowIndex + 1, length, useArray, returnValue);
            }
        }
    }
}
