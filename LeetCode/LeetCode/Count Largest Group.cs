using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Count_Largest_Group
    {
        public int CountLargestGroup(int n)
        {
			int largest = 0, numLargest = 0;
			int[] arr = new int[37];
			for (int i = 1; i <= n; i++)
			{
				int temp = i, digitSum = 0;
				while (temp > 0)
				{
					digitSum += temp % 10;
					temp /= 10;
				}

				arr[digitSum]++;
				if (arr[digitSum] > largest)
				{
					largest = arr[digitSum];
					numLargest = 1;
				}
				else if (arr[digitSum] == largest) numLargest++;
			}

			return numLargest;
		}
    }
}
