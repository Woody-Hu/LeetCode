using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Duplicate_Zeros
    {
        public void DuplicateZeros(int[] arr)
        {
            var count = 0;
            var index = 0;
            for (; index + count < arr.Length; index++)
            {
                count += arr[index] == 0 ? 1: 0;
            }

            for (index = index - 1; count > 0 ; index-- )
            {
                if (index + count < arr.Length)
                {
                    arr[index + count] = arr[index];
                }

                if (arr[index] == 0)
                {
                    arr[index + --count] = arr[index];
                }
            }
        }
    }
}
