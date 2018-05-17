using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AddStrings
    {
        public string AddStringsMethod(string num1, string num2)
        {
            StringBuilder returnValue = new StringBuilder();

            int tempValue = 0;
            int nextUseValue = 0;
            int useNum1Index = num1.Length - 1;
            int useNum2Index = num2.Length - 1;

            for (; useNum1Index >= 0 && useNum2Index >= 0; useNum1Index--,useNum2Index--)
            {
                tempValue = num1[useNum1Index] - '0' + num2[useNum2Index] - '0' + nextUseValue;

                returnValue.Append(tempValue % 10);
                nextUseValue = tempValue / 10;
            }

            for (; useNum1Index >= 0; useNum1Index--)
            {
                tempValue = num1[useNum1Index] - '0' + nextUseValue;

                returnValue.Append(tempValue % 10);
                nextUseValue = tempValue / 10;
            }

            for (; useNum2Index >= 0; useNum2Index--)
            {
                tempValue = num2[useNum2Index] - '0' + nextUseValue;

                returnValue.Append(tempValue % 10);
                nextUseValue = tempValue / 10;
            }

            if (0 != nextUseValue)
            {
                 returnValue.Append(nextUseValue);
            }

            return new string(returnValue.ToString().Reverse().ToArray());
           
        }
    }
}
