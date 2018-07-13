using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ToLowerCase
    {
        public string ToLowerCaseMethod(string str)
        {
            StringBuilder returnValue = new StringBuilder();

            foreach (var oneValue in str)
            {
                if (char.IsLetter(oneValue) && char.IsUpper(oneValue))
                {
                    returnValue.Append((char)(oneValue + 32));
                }
                else
                {
                    returnValue.Append(oneValue);
                }
            }

            return returnValue.ToString();

        }
    }
}
