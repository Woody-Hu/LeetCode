using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinimumIndexSumofTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dic1 = new Dictionary<string, int>();

            for (int i = 0; i < list1.Count(); i++)
            {
                dic1.Add(list1[i], i);
            }

            int minIndex = int.MaxValue;

            List<string> returnValue = new List<string>();

            for (int i = 0; i < list2.Count(); i++)
            {
                if (!dic1.ContainsKey(list2[i]))
                {
                    continue;
                }

                var tempIndex = i + dic1[list2[i]];

                if (tempIndex < minIndex)
                {
                    minIndex = tempIndex;
                    returnValue = new List<string>() { list2[i]};
                }
                else if (tempIndex == minIndex)
                {
                    returnValue.Add(list2[i]);
                }
            }

            return returnValue.ToArray();
        }
    }
}
