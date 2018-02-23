using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SelfDividingNumbers
    {
        public IList<int> SelfDividingNumbersMethod(int left, int right)
        {
            List<int> returnValue = new List<int>();
            int tempValue;
            for (int index = left; index <= right; index++)
            {
                if (index == 0)
                {
                    continue;
                }
                tempValue = index;
                while (tempValue != 0)
                {
                    if (tempValue % 10 == 0 || (index % (tempValue % 10)) != 0)
                    {
                        break;
                    }
                    tempValue = tempValue / 10;
                }

                if (0 == tempValue)
                {
                    returnValue.Add(index);
                }
            }

            return returnValue;
        }

        
    }
}
