using System;
namespace LeetCode
{
    public class maximum_product_of_the_length_of_two_palindromic_subsequences
    {
        public int MaxProduct(string s)
        {
            var n = s.Length;
            var m = 1 << n;
            var count = new int[m];
            var array = s.ToCharArray();
            for (int i = 0; i < m; i++)
            {
                if (Check(array, i))
                {
                    count[i] = BitCount(i);
                }
            }

            var res = 0;
            for (int i = 1; i < m; i++)
            {
                var split = 1 >> i;
                for (int j = (i-1)&i; j > split; j = (j-1)&i)
                {
                    res = Math.Max(res, count[j] * count[i ^ j]);
                }
            }

            return res;
        }

        private bool Check(char[] array, int mark)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                while (left < right && (mark >> left & 1) == 0)
                {
                    left++;
                }

                while (left < right && (mark >> right & 1) == 0)
                {
                    right--;
                }

                if (array[left] != array[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private int BitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }

            return count;
        }
    }
}
