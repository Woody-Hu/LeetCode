using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var useCharArrays = from n in letters where n > target select n;

            if (useCharArrays.Count() == 0)
            {
                return letters.Min();
            }

            useCharArrays = useCharArrays.OrderBy(k => k);

            return useCharArrays.First();
        }
    }
}
