using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Course_Schedule_II
    {
        public int[] FindOrder(int numCourses, int[,] prerequisites)
        {
            var edges = new int[numCourses, numCourses];
            var dependsCount = new int[numCourses];

            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                var per = prerequisites[i, 1];
                var next = prerequisites[i, 0];
                if (edges[per, next] == 0)
                {
                    dependsCount[next]++;
                }

                edges[per, next] = 1;
            }

            var queue = new Queue<int>();

            for (int i = 0; i < dependsCount.Length; i++)
            {
                if (dependsCount[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            var count = 0;
            var list = new List<int>();
            while (queue.Count != 0 )
            {
                var value = queue.Dequeue();
                list.Add(value);
                count++;
                for (int i = 0; i < dependsCount.Length; i++)
                {
                    if (edges[value,i] != 0)
                    {
                        if (--dependsCount[i] == 0)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }

            if (count == numCourses)
            {
                return list.ToArray();
            }

            return new int[0];
        }
    }
}
