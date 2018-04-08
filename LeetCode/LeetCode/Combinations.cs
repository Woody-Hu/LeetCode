using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            if (k == 1)
            {
                IList<IList<int>> returnValue = new List<IList<int>>();
                for (int i = 1; i <= n; i++)
                {
                    returnValue.Add(new List<int>() { i });
                }
                return returnValue;
            }
            else
            {
                return CombineSub(n, k, 1);
            }
        }

        private IList<IList<int>> CombineSub(int n, int k,int startValue)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();
            if (k == 2)
            {
                for (int i = startValue; i <= n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        returnValue.Add(new List<int>() { i, j });
                    }
                }
            }
            else
            {
                for (int i = startValue + 1; i <= n; i++)
                {
                    IList<IList<int>> nextLoopValue = CombineSub(n, k - 1, i);
                    foreach (var oneValue in nextLoopValue)
                    {
                        oneValue.Insert(0, i - 1);
                        returnValue.Add(oneValue);
                    }
                }
               
            }

            return returnValue;
        }
    }
}
