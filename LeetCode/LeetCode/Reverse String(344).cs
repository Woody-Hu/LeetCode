using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseStringClass
    {
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in s.Reverse())
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
