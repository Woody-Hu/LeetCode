using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode
{
    class Course_Schedule
    {
        public bool CanFinish(int numCourses, int[,] prerequisites)
        {
            var edges = new int[numCourses, numCourses];
            var dependsCount = new int[numCourses];

            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                var per = prerequisites[i, 1];
                var next = prerequisites[i, 0];
                if (edges[per,next] == 0)
                {
                    dependsCount[next]++;
                }

                edges[per, next] = 1;
            }

            var useQueue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (dependsCount[i] == 0)
                {
                    useQueue.Enqueue(i);
                }
            }

            var count = 0;
            while (useQueue.Count != 0)
            {
                var visitedValue = useQueue.Dequeue();
                count++;
                for (int i = 0; i < numCourses; i++)
                {
                    if (edges[visitedValue,i] != 0)
                    {
                        if ( --dependsCount[i] == 0)
                        {
                            useQueue.Enqueue(i);
                        }
                    }
                }
            }

            return count == numCourses;
        }
    }
}
