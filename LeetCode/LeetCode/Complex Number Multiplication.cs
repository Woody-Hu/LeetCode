using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Complex_Number_Multiplication
    {
        public string ComplexNumberMultiply(string a, string b)
        {
            var indexA1 = a.IndexOf('+');
            var indexA2 = a.IndexOf('i');
            var a1 = int.Parse(a.Substring(0, indexA1));
            var b1 = int.Parse(a.Substring(indexA1 + 1, indexA2 - indexA1 -1));

            var indexB1 = b.IndexOf('+');
            var indexB2 = b.IndexOf('i');

            var a2 = int.Parse(b.Substring(0, indexB1));
            var b2 = int.Parse(b.Substring(indexB1 + 1, indexB2 - indexB1 - 1));

            var c1 = a1 * a2;
            var c2 = b1 * b2 * -1;
            var c3 = b2 * a1 + a2 * b1;

            return $"{c1 + c2}+{c3}i";
        }
    }
}
