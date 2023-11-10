using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class minimum_processing_time
	{
        public int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            var processorTimeList = processorTime.ToList();
            var tasksList = tasks.ToList();
            tasksList.Reverse();
            processorTimeList.Sort();
            tasksList.Sort();
            var result = 0;
            for (var i = 0; i < tasksList.Count; i++)
            {
                result = Math.Max(result, processorTimeList[i] + tasksList[i * 4]);
            }

            return result;
        }
    }
}

