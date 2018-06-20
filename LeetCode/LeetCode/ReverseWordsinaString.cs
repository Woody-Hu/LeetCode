using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseWordsinaString
    {
        public string ReverseWords(string s)
        {

            StringBuilder returnValue = new StringBuilder();
            var spliteValue = s.Split(' ');

            for (int i = spliteValue.Length - 1; i >=0; i--)
            {
                if (string.IsNullOrWhiteSpace(spliteValue[i]))
                {
                    continue;
                }
                returnValue.Append(spliteValue[i].Trim());

                if (i!=0)
                {
                    returnValue.Append(" ");
                }
            }

            return returnValue.ToString().Trim();
        }
    }
}
