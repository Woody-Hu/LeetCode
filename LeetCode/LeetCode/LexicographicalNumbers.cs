using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LexicographicalNumbers
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> returnValue = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                DfsLoop(i, n, returnValue);
            }

            return returnValue;
        }

        private void DfsLoop(int input,int inputMax,List<int> inputList)
        {
            if (input > inputMax)
            {
                return;
            }
            inputList.Add(input);

            for (int i = 0; i < 10; i++)
            {
                DfsLoop(input * 10 + i, inputMax, inputList);
            }

        }
    }
}
