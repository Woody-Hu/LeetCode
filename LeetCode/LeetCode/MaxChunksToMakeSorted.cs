using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MaxChunksToMakeSorted
    {
        public int MaxChunksToSorted(int[] arr)
        {
            if (null == arr || 0 == arr.Length)
            {
                return 0;
            }

            int useChunks = 0;
            int useMaxValue = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                useMaxValue = Math.Max(useMaxValue, arr[i]);

                if (useMaxValue == i)
                {
                    useChunks++;
                }
            }

            return useChunks;


        }
    }
}
