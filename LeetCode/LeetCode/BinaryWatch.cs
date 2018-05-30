using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            List<string> returnValue = new List<string>();

            int[] hours = new int[] { 1, 2, 4, 8 };

            int[] minutes = new int[] { 1, 2, 4, 8, 16, 32 };

            for (int i = 0; i < 4; i++)
            {
                if (i > num)
                {
                    continue;
                }
                List<int> useHoursNumbers = GetValues(hours, i);
                List<int> useMinutesNumbers = GetValues(minutes, num - i);

                foreach (var hoursValue in useHoursNumbers)
                {
                    if (hoursValue > 11)
                    {
                        continue;
                    }

                    foreach (var minuteValue in useMinutesNumbers)
                    {
                        if (minuteValue > 59)
                        {
                             continue;
                        }

                        returnValue.Add(hoursValue.ToString() + ":" + (minuteValue < 10 ? "0" + minuteValue.ToString() : minuteValue.ToString()));
                    }
                }
            }
            return returnValue;
        }


        private List<int> GetValues(int[] inputArray,int inputCount)
        {

            List<int> returnValue = new List<int>();

            InnerMethod(inputArray, inputCount, 0, 0, returnValue);
            return returnValue;

        }

        private void InnerMethod(int[] inputArray,int inputCount,int inputIndex,int inputSum,List<int> useLst)
        {
            if (inputCount == 0)
            {
                useLst.Add(inputSum);
                return;
            }

            for (int i = inputIndex; i < inputArray.Length; i++)
            {
                InnerMethod(inputArray, inputCount - 1, i + 1, inputSum + inputArray[i], useLst);
            }
        }


    }
}
