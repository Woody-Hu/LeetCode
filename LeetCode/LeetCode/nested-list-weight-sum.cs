using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class nested_list_weight_sum
    {
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            var res = 0;
            Visit(nestedList, 1, ref res);
            return res;
        }

        private void Visit(IList<NestedInteger> nestedList, int deep, ref int res)
        {
            foreach (var item in nestedList)
            {
                if (item.IsInteger())
                {
                    res += item.GetInteger() * deep;
                }
                else
                {
                    Visit(item.GetList(), deep + 1, ref res);
                }
            }
        }


        public interface NestedInteger {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value);

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni);

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    }
}
