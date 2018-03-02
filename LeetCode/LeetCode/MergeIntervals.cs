using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MergeIntervals
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            if (null == intervals || 0 == intervals.Count)
            {
                return intervals;
            }

            List<Interval> returnValue = new List<Interval>();

            var tempLst = intervals.OrderBy(k => k.start);

            int start = tempLst.ElementAt(0).start;

            int end = tempLst.ElementAt(0).end;

            foreach (var oneInterval in tempLst)
            {
                if (oneInterval.start <= end)
                {
                    end = Math.Max(oneInterval.end, end);
                }
                else
                {
                    returnValue.Add(new Interval(start, end));
                    start = oneInterval.start;
                    end = oneInterval.end;
                }
            }

            returnValue.Add(new Interval(start, end));

            return returnValue;


        }
    }
}
