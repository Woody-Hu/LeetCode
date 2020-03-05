using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Element_Appearing_More_Than_25_In_Sorted_Array
    {
        public int FindSpecialInteger(int[] arr)
        {
            int max = arr.Length / 4;
            int i = 0;
            while (i < arr.Length)
            {
                int num = arr[i];
                if (i + max < arr.Length && arr[i + max] == num)
                {
                    return num;
                }

                while (arr[i] == num)
                {
                    i++;
                }
            }

            return 1;
        }
    }
}
