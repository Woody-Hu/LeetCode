using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int startIndex = 0; int endIndex = height.Length - 1;
            int returnValue = 0;

            while (startIndex<endIndex)
            {
                if (height[startIndex]<height[endIndex])
                {
                    var tempValue = (endIndex - startIndex) * height[startIndex];
                    startIndex++;
                    returnValue = Math.Max(returnValue, tempValue);
                }
                else
                {
                    var tempValue = (endIndex - startIndex) * height[endIndex];
                    endIndex--;
                    returnValue = Math.Max(returnValue, tempValue);
                }
            }

            return returnValue;
        }
    }
}
