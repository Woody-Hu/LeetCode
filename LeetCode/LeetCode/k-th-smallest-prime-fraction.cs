using System;
namespace LeetCode
{
    public class k_th_smallest_prime_fraction
    {
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            var n = arr.Length;
            var left = 0.0;
            var right = 1.0;
            while (true)
            {
                var mid = (left + right) / 2;
                var i = -1;
                var count = 0;
                var x = 0;
                var y = 1;
                for (int j = 1; j < n; j++)
                {
                    while ((double)arr[i + 1] / arr[j] < mid)
                    {
                        i++;
                        if (arr[i] * y > arr[j] * x)
                        {
                            x = arr[i];
                            y = arr[j];
                        }
                    }

                    count += i + 1;
                }

                if (count == k)
                {
                    return new int[] { x, y };
                }
                else if (count < k)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            return null;
        }
    }
}
