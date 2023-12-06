﻿using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_the_peaks
	{
        public IList<int> FindPeaks(int[] mountain)
        {
            var res = new List<int>();
            for (int i = 1; i < mountain.Length - 1; i++)
            {
                if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}

