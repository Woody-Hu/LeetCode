using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ShuffleanArray
    {
        private int[] inputValue;

        Random useRandom = new Random();

        public ShuffleanArray(int[] nums)
        {
            inputValue = nums;
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return inputValue;

        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            if (null == inputValue)
            {
                return null;
            }
            var tempArray = inputValue.Clone() as int[];

            for (int i = 1; i < inputValue.Length; i++)
            {
                int tempIndex = useRandom.Next(i+1);

                int t = tempArray[tempIndex];

                tempArray[tempIndex] = tempArray[i];

                tempArray[i] = t;
            }

            return tempArray;
        }
    }
}
