using System;
namespace LeetCode
{
	public class smallest_value_of_the_rearranged_number
	{
        public long SmallestNumber(long num)
        {
            var temp = num;
            var count = new int[10];
            num = Math.Abs(num);
            while (num != 0)
            {
                var cur = (int)(num % 10);
                count[cur]++;
                num /= 10;
            }

            var res = 0l;
            if (temp > 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (count[i] != 0)
                    {
                        res = i;
                        count[i]--;
                        break;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    while (count[i] > 0)
                    {
                        res = res * 10 + i;
                        count[i]--;
                    }
                }
            }
            else
            {
                for (int i = 9; i >= 0; i--)
                {
                    while (count[i] > 0)
                    {
                        res = res * 10 + i;
                        count[i]--;
                    }
                }
                res *= -1;
            }

            return res;
        }
    }
}

