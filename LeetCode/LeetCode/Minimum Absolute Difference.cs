using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Absolute_Difference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var res = new List<IList<int>>();
            Array.Sort(arr);
            var min = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var dif = Math.Abs(arr[i] - arr[i + 1]);
                if (dif > min)
                {
                    continue;
                }
                else if (dif == min)
                {
                    res.Add(new List<int>() { arr[i], arr[i + 1] });
                }
                else
                {
                    min = dif;
                    res.Clear();
                    res.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }

            return res;
        }
    }
}
