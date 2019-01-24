using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Combination_Sum_III
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var array = new int[9];

            for (int i = 1; i <= 9; i++)
            {
                array[i - 1] = i;
            }

            var returnValue = new List<IList<int>>();
            var list = new List<int>();
            CombinationSum3(array, 0, k, n, returnValue, list);
            return returnValue;
        }

        private void CombinationSum3(int[] array, int startIndex, int limitCount, int sum, IList<IList<int>> returnValue,
            IList<int> list)
        {

            if (sum == 0 && list.Count == limitCount)
            {
                returnValue.Add(new List<int>(list));
                return;
            }

            if (sum <0 || startIndex > array.Length)
            {
                return;
            }

            for (int i = startIndex; i < array.Length; i++)
            {
                list.Add(array[i]);
                CombinationSum3(array, i + 1, limitCount, sum - array[i], returnValue, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
