using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumberofBoomerangs
    {
        public int NumberOfBoomerangs(int[,] points)
        {
            int returnValue = 0;
            Dictionary<int, int> tempDic = new Dictionary<int, int>();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                tempDic.Clear();
                for (int j = 0; j < points.GetLength(0); j++)
                {
                    int tempDis = (int)(Math.Pow(points[i, 0] - points[j, 0], 2) + Math.Pow(points[i, 1] - points[j, 1], 2));

                    if (!tempDic.ContainsKey(tempDis))
                    {
                        tempDic.Add(tempDis, 0);
                    }
                    tempDic[tempDis]++;
                }

                foreach (var oneKvp in tempDic)
                {
                    returnValue += oneKvp.Value * (oneKvp.Value - 1);
                }
            }

            return returnValue;
        }
    }
}
