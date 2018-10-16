using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            int num1Length = num1.Length;
            int num2Length = num2.Length;

            int[] resArray = new int[num1Length+num2Length];

            for (int i = num1Length-1; i >=0; i--)
            {
                for (int j = num2Length-1; j >=0; j--)
                {
                    var tempValue = (num1[i] - '0') * (num2[j] - '0');

                    tempValue = tempValue + resArray[i + j + 1];

                    resArray[i + j] += tempValue / 10;
                    resArray[i + j + 1] = tempValue % 10;
                }
            }

            StringBuilder returnValue = new StringBuilder();

            foreach (var oneValue in resArray)
            {
                if (!(returnValue.Length == 0 && oneValue == 0 ))
                {
                    returnValue.Append(oneValue);
                }
            }

            return returnValue.Length == 0 ? "0" : returnValue.ToString();
        }
    }
}
