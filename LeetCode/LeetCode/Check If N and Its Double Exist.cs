using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Check_If_N_and_Its_Double_Exist
    {
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            var set = new HashSet<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (set.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && set.Contains(arr[i] / 2)))
                {
                    return true;
                }

                set.Add(arr[i]);
            }

            return false;
        }
    }
}
