using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Queue_Reconstruction_by_Height
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var peopleList = new List<int[]>();
            var output = new List<int[]>();
            peopleList = people.OrderByDescending(a => a[0]).ThenBy(a => a[1]).ToList();
            for (int i = 0; i < peopleList.Count; i++)
            {
                output.Insert(peopleList[i][1], peopleList[i]);
            }

            return output.ToArray();
        }
    }
}
