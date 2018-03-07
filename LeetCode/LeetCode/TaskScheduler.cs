using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TaskScheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int returnValue = 0;
            var tempLstKVP = from c in tasks.GroupBy(k => k) select new KeyValuePair<char, int>(c.Key, c.Count());
            tempLstKVP = tempLstKVP.OrderBy(k=>-k.Value);

            int oneGroupCount = 1 + n;

            int maxCount = tempLstKVP.ElementAt(0).Value;

            returnValue = oneGroupCount * (maxCount - 1);

            foreach (var oneKVP in tempLstKVP)
            {
                if (oneKVP.Value == maxCount)
                {
                    returnValue++;
                }
                else
                {
                    break;
                }
            }

            return Math.Max(tasks.Count(), returnValue);

        }
    }
}
