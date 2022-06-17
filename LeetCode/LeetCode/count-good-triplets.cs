using System;
namespace LeetCode
{
    public class count_good_triplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            var res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[k] - arr[i]) <= c)
                        {
                            res++;
                        }
                    }
                }
            }

            return res;
        }
    }
}
