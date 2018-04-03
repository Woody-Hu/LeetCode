using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BasicCalculatorII
    {
        public int Calculate(string s)
        {
            int useLength = s.Length;

            int returnValue = 0;

            int nowValue = 0;

            char useTag = '+';                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

            Stack<int> useStack = new Stack<int>();

            for (int i = 0; i < useLength; i++)
            {

                if (Char.IsDigit(s[i]))
                {
                    nowValue = s[i] - '0';

                    while (i+1< useLength && Char.IsDigit(s[i+1]))
                    {
                        nowValue = nowValue * 10 + s[i + 1] - '0';
                        i++;
                    }


                }

                if (!char.IsDigit(s[i]) && s[i] != ' ' || i == useLength - 1)
                {
                    if (useTag == '+')
                    {
                        useStack.Push(nowValue);
                    }
                    else if (useTag == '-')
                    {
                        useStack.Push(-nowValue);
                    }
                    else if (useTag == '*')
                    {
                        useStack.Push(useStack.Pop() * nowValue);
                    }
                    else if (useTag == '/')
                    {
                        useStack.Push(useStack.Pop() / nowValue);
                    }

                    useTag = s[i];
                    nowValue = 0;
                }
            }

            foreach (var oneValue in useStack)
            {
                returnValue += oneValue;
            }

            return returnValue;
        }
    }
}
