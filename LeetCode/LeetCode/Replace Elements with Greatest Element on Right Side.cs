using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Replace_Elements_with_Greatest_Element_on_Right_Side
    {
        public int[] ReplaceElements(int[] arr)
        {
            var max = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = max;
                max = Math.Max(temp, max);
            }

            return arr;
        }
    }
}
