using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class IncreasingSubsequences
    {
        public IList<IList<int>> FindSubsequences(int[] nums)
        {

            List<IList<int>> returnValue = new List<IList<int>>();

            List<int> nowLst = new List<int>();

            InnerMethod(nums, returnValue, 0, nowLst);




            return returnValue;
        }

        public void InnerMethod(int[] nums, List<IList<int>> list, int start, List<int> curlist)
        {
            HashSet<int> used = new HashSet<int>();
            for (int i = start; i < nums.Length; i++)
            {
                if (i != start && used.Contains(nums[i]))
                    continue;
                used.Add(nums[i]);
                if (curlist.Count == 0 || nums[i] >= curlist.Last())
                {
                    curlist.Add(nums[i]);
                    if (curlist.Count >= 2)
                    {
                        list.Add(new List<int>(curlist));
                    }
                    InnerMethod(nums, list, i + 1, curlist);
                    curlist.RemoveAt(curlist.Count - 1);
                }
            }



        }




    }
}
