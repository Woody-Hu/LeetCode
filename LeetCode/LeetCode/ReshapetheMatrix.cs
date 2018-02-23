using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReshapetheMatrix
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int useR = nums.GetLength(0);
            int useC = nums.GetLength(1);

            if (useR * useC != r*c)
            {
                return nums;
            }

            int tempr = 0;
            int tempc = 0;
            int useCusbOne = c -1;

            int[,] returnValue = new int[r, c];

            for (int rIndex = 0; rIndex < useR; rIndex++)
            {
                for (int cIndex = 0; cIndex < useC; cIndex++)
                {
                    returnValue[tempr, tempc] = nums[rIndex, cIndex];
                    tempc++;
                    if (tempc > useCusbOne)
                    {
                        tempr++;
                        tempc = 0;
                    }
                }
            }

            return returnValue;
        }
    }
}
