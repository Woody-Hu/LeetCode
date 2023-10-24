using System;
namespace LeetCode
{
	public class reducing_dishes
	{
        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction, (a, b) => b - a);
            var pre = 0;
            var res = 0;
            foreach (var item in satisfaction)
            {
                if (pre + item > 0)
                {
                    pre += item;
                    res += pre;
                }
                else
                {
                    break;
                }
            }

            return res;
        }
    }
}

