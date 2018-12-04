using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LargestTimeforGivenDigits
    {
        public string LargestTimeFromDigits(int[] A)
        {
            var usedIndexes = new HashSet<int>();
            var maxHour = -1;
            var maxMinute = -1;
            var useArray = new int[4];

            LargestTimeFromDigits(A, usedIndexes, 0, useArray, ref maxHour, ref maxMinute);


            if (-1 == maxHour && -1 == maxMinute)
            {
                return string.Empty;
            }
            else
            {
                return (maxHour < 10 ? "0" + maxHour.ToString() : maxHour.ToString()) + ":" + (maxMinute < 10 ? "0" + maxMinute.ToString() : maxMinute.ToString());
            }
        }

        private void LargestTimeFromDigits(int[] A, HashSet<int> usedIndexes, int useIndex, int[] useArray, ref int maxHour, ref int maxMinute)
        {
            if (useIndex >= A.Length)
            {
                var nowHour = useArray[0] * 10 + useArray[1];
                var nowMinute = useArray[2] * 10 + useArray[3];

                if (nowHour >= 24 || nowMinute >= 60)
                {
                    return;
                }

                if (nowHour > maxHour)
                {
                    maxHour = nowHour;
                    maxMinute = nowMinute;
                }
                else if (nowHour == maxHour && nowMinute > maxMinute)
                {
                    maxMinute = nowMinute;
                }
                return;
            }

            var value = A[useIndex];

            for (var i = 0; i < 4; i++)
            {
                if (usedIndexes.Contains(i))
                {
                    continue;
                }

                usedIndexes.Add(i);

                useArray[i] = value;

                LargestTimeFromDigits(A, usedIndexes, useIndex + 1, useArray, ref maxHour, ref maxMinute);

                usedIndexes.Remove(i);
            }
        }
    }
}
