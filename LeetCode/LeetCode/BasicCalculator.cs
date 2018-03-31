using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BasicCalculator
    {
        public int Calculate(string s)
        {
            Stack<int> useStack = new Stack<int>();

            int tag = 1;

            int returnValue = 0;

            int useLength = s.Length;

            for (int i = 0; i < useLength; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    int tempValue = s[i] - '0';

                    while (i+1 <useLength && Char.IsDigit(s[i+1]))
                    {
                        tempValue = tempValue * 10 + s[i + 1] - '0';
                        i++;
                    }

                    returnValue += tag * tempValue;
                }
                else if (s[i] == '+')
                {
                    tag = 1; 
                }
                else if (s[i] == '-')
                {
                    tag = -1; 
                }
                else if (s[i] == '(')
                {
                    useStack.Push(tag);
                    useStack.Push(returnValue);
                    tag = 1;
                    returnValue = 0;

                }
                else if (s[i] == ')')
                {
                    returnValue = useStack.Pop() + useStack.Pop() * returnValue;
                }
            }

            return returnValue;

        }
    }
}
