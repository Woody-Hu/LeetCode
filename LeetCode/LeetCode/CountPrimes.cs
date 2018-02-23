using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CountPrimes
    {
        public int CountPrimesMethod(int n)
        {
            bool[] primeArray = new bool[n];

            for (int oneIndex = 0; oneIndex < n; oneIndex++)
            {
                primeArray[oneIndex] = true;
            }

            for (int firstIndex = 2; firstIndex < n; firstIndex++)
            {
                if (!primeArray[firstIndex])
                {
                    continue;
                }
                for (int secondIndex = 2*firstIndex; secondIndex < n; secondIndex = secondIndex + firstIndex)
                {
                    primeArray[secondIndex] = false;
                }
            }

            int count = 0;

            for (int i = 2; i < n; i++)
            {
                if (primeArray[i])
                {
                    count++;
                }
            }
 
                

            return count;
          
        
        }
    }
}
