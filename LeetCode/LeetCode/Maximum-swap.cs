using System;
namespace LeetCode
{
    public class Maximum_swap
    {
        public int MaximumSwap(int num)
        {
            var array = num.ToString().ToCharArray();
            var last = new int[10];
            var length = array.Length;
            for (int i = 0; i < length; i++)
            {
                last[array[i] - '0'] = i;
            }

            for (int i = 0; i < length - 1; i++)
            {
                for (int k = 9; k >= array[i] - '0'; k--)
                {
                    if (last[k] > i)
                    {
                        char temp = array[i];
                        array[i] = array[last[k]];
                        array[last[k]] = temp;
                        return int.Parse(array);
                    }
                }
            }

            return num;
        }
    }
}
