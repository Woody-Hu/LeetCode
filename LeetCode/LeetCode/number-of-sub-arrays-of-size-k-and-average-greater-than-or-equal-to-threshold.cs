using System;
namespace LeetCode
{
    public class number_of_sub_arrays_of_size_k_and_average_greater_than_or_equal_to_threshold
    {
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            var res = 0;
            var sum = 0;
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (i -j >= k)
                {
                    sum -= arr[j++];
                }

                if (i - j +1 == k && sum>= k * threshold)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
