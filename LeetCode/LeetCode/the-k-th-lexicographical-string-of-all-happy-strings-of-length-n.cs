using System;
using System.Text;

namespace LeetCode
{
    public class the_k_th_lexicographical_string_of_all_happy_strings_of_length_n
    {
        public string GetHappyString(int n, int k)
        {
            var sum = 3 << (n - 1);
            if (k > sum)
            {
                return string.Empty;
            }

            var res = new StringBuilder();
            var charDt = new int[,] { { 1, 2 }, { 0, 2 }, { 0, 1 } };
            var totalOrder = k - 1;
            var current = totalOrder >> (n - 1);
            res.Append((char)(current + 'a'));
            var treeOrder = totalOrder & ((1 << (n - 1)) - 1);
            for (int i = n - 2; i >= 0; i--)
            {
                current = charDt[current, (treeOrder >> i) & 1];
                res.Append((char)(current + 'a'));
            }

            return res.ToString();
        }
    }
}
