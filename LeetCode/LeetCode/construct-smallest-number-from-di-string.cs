using System;
namespace LeetCode
{
    public class construct_smallest_number_from_di_string
    {
        public string SmallestNumber(string pattern)
        {
            var i = 0;
            var n = pattern.Length;
            var current = 1;
            var res = new char[n + 1];
            while (i < n)
            {
                if (i > 0 && pattern[i] == 'I')
                {
                    ++i;
                }

                for (; i < n && pattern[i] == 'I'; ++i)
                {
                    res[i] = (char)(current++ + '0');
                }

                var i0 = i;
                while (i < n && pattern[i] == 'D')
                {
                    ++i;
                }

                for (int j = i; j >= i0; --j)
                {
                    res[j] = (char)(current++ + '0');
                }
            }

            return new string(res);
        }
    }
}
