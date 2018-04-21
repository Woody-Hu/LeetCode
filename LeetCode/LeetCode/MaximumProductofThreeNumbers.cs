using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaximumProductofThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            var orderedValue = nums.OrderBy(k => -k);

            return Math.Max(orderedValue.ElementAt(0) * orderedValue.ElementAt(1) * orderedValue.ElementAt(2)
                , orderedValue.ElementAt(0) * orderedValue.ElementAt(orderedValue.Count() - 1) * orderedValue.ElementAt(orderedValue.Count() - 2));
        }
    }
}
