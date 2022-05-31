using System;
namespace LeetCode
{
    public class monotone_increasing_digits
    {
        public int MonotoneIncreasingDigits(int n)
        {
            var array = n.ToString().ToCharArray();
            var i = 1;
            while (i < array.Length && array[i - 1] <= array[i])
            {
                i++;
            }

            if (i < array.Length )
            {
                while (i > 0 && array[i - 1] > array[i])
                {
                    array[i - 1] = (char)((int)array[i - 1] - 1);
                    i--;
                }

                for (i++; i < array.Length; i++)
                {
                    array[i] = '9';
                }
            }

            return int.Parse(new string(array));
        }
    }
}
