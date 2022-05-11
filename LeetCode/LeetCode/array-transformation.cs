using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class array_transformation
    {
        public IList<int> TransformArray(int[] arr)
        {
            while (true)
            {
                var count = 0;
                var temp = arr.ToList();
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i - 1] < arr[i] && arr[i] > arr[i+1])
                    {
                        temp[i]--;
                        count++;
                    }

                    if (arr[i - 1] > arr[i] && arr[i] < arr[i + 1])
                    {
                        temp[i]++;
                        count++;
                    }
                }

                if (count == 0)
                {
                    return temp;
                }

                arr = temp.ToArray();
            }

            return arr;
        }
    }
}
