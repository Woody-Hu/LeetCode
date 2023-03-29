using System;
namespace LeetCode
{
	public class minimum_number_of_days_to_make_m_bouquets
	{
        public int MinDays(int[] bloomDay, int m, int k)
        {
            if (m > bloomDay.Length/k)
            {
                return -1;
            }

            var low = int.MaxValue;
            var high = int.MinValue;
            foreach (var item in bloomDay)
            {
                low = Math.Min(item, low);
                high = Math.Max(item, high);
            }

            while (low < high)
            {
                var current = (low + high) / 2;
                if (InternalCalculate(bloomDay, current, m, k))
                {
                    high = current;
                }
                else
                {
                    low = current + 1;
                }
            }

            return low;
        }

        private bool InternalCalculate(int[] bloomDay, int input, int m, int k)
        {
            var b = 0;
            var f = 0;
            for (int i = 0; i < bloomDay.Length && b < m; i++)
            {
                if (bloomDay[i] <= input)
                {
                    f++;
                    if (f == k)
                    {
                        b++;
                        f = 0;
                    }
                }
                else
                {
                    f = 0;
                }
            }

            return b >= m;
        }
    }
}

