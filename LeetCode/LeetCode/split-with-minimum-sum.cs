using System;
namespace LeetCode
{
	public class split_with_minimum_sum
	{
        public int SplitNum(int num)
        {
            var array = num.ToString().ToCharArray();
            Array.Sort(array);
            var num1 = 0;
            var num2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    num1 = num1 * 10 + (array[i] - '0');
                }
                else
                {
                    num2 = num2 * 10 + (array[i] - '0');
                }
            }

            return num1 + num2;
        }
    }
}

