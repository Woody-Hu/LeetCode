using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DifferentWaystoAddParentheses
    {
        public IList<int> DiffWaysToCompute(string input)
        {
            List<int> nowLst = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*')
                {
                    string frontStr = input.Substring(0, i);
                    string tailStr = input.Substring(i + 1);
                    var forntValue = DiffWaysToCompute(frontStr);
                    var backValue = DiffWaysToCompute(tailStr);

                    foreach (var oneFrontValue in forntValue)
                    {
                        foreach (var oneBackValue in backValue)
                        {
                            switch (input[i])
                            {
                                case '+':
                                    nowLst.Add(oneFrontValue + oneBackValue);
                                    break;
                                case '-':
                                    nowLst.Add(oneFrontValue - oneBackValue);
                                    break;
                                case '*':
                                    nowLst.Add(oneFrontValue * oneBackValue);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                }
            }

            if (0 == nowLst.Count)
            {
                nowLst.Add(int.Parse(input));
            }

            return nowLst;
        }
    }
}
