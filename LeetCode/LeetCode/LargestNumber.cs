using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LargestNumber
    {
        public string LargestNumberMethod(int[] nums)
        {
            var tempStrNums = (from n in nums select n.ToString()).ToList();

            tempStrNums.Sort(new UseComparer());

            StringBuilder returnValue = new StringBuilder();

            if (tempStrNums[0][0] == '0')
            {
                return "0";
            }

            foreach (var oneStr in tempStrNums)
            {
                returnValue.Append(oneStr);
            }

            return returnValue.ToString();
        }

        private class UseComparer:Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                string a = x + y;
                string b = y + x;

                return b.CompareTo(a);
            }
        }
    }
}
