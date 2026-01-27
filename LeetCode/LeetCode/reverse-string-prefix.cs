using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class reverse_string_prefix
    {
        public string ReversePrefix(string s, int k)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr, 0, k);
            return new string(arr);

        }
    }
}
