using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Numbers_with_Even_Number_of_Digits
    {
        public int FindNumbers(int[] nums)
        {
            var res = 0;
            foreach (var oneNum in nums)
            {
                if (IsEvenNumber(oneNum))
                {
                    res++;
                }
            }

            return res;
        }

        private bool IsEvenNumber(int num)
        {
            if (9 < num && num < 100)
                return true;

            if (999 < num && num < 10000)
                return true;

            if (num == 100000)
                return true;

            return false;
        }
    }
}
