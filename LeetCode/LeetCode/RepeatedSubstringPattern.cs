using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPatternMethod(string s)
        {
            string tempString = s + s;

            tempString = tempString.Substring(1);

            tempString = tempString.Substring(0, tempString.Length - 1);

            return tempString.IndexOf(s) != -1;


        }

    }
}
