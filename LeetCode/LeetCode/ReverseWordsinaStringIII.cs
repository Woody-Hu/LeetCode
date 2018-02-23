using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseWordsinaStringIII
    {
        public string ReverseWords(string s)
        {
            StringBuilder returnValue = new StringBuilder();

            var alls = s.Split(' ');

            for (int i = 0; i < alls.Count(); i++)
            {
                returnValue.Append(new string(alls[i].Reverse().ToArray()));
                if (i != alls.Count() - 1)
                {
                    returnValue.Append(" ");
                }
            }

            return returnValue.ToString();

        }
    }
}
