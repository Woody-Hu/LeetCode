using System;
namespace LeetCode
{
    public class detect_pattern_of_length_m_repeated_k_or_more_times
    {
        public bool ContainsPattern(int[] arr, int m, int k)
        {
            var n = arr.Length;
            for (int i = 0; i <= n - m*k; i++)
            {
                var offset = 0;
                for (; offset <m*k; offset++)
                {
                    if (arr[i + offset] != arr[i + offset%m])
                    {
                        break;
                    }
                }

                if (offset == m*k)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

