using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            return InnerMethod(S).Equals(InnerMethod(T));

        }

        private string InnerMethod(string inputString)
        {
            List<char> lstChar = new List<char>();
            int count = 0;
            for (int i = inputString.Length - 1; i >= 0; )
            {
                if (inputString[i] != '#')
                {
                    if (count > 0) count--;
                    else lstChar.Add(inputString[i]);
                    i--;
                }
                else
                {
                    while (i >= 0 && inputString[i] == '#')
                    {
                        i--;
                        count++;
                    }
                }
            }
            return new string(lstChar.ToArray());
        }
    }
}
