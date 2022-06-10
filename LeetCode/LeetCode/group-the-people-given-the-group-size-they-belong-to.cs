using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class group_the_people_given_the_group_size_they_belong_to
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var res = new List<IList<int>>();
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                var value = groupSizes[i];
                if (!dic.ContainsKey(value))
                {
                    dic[value] = new List<int>(value);
                }

                dic[value].Add(i);
                if (dic[value].Count == value)
                {
                    res.Add(dic[value]);
                    dic.Remove(value);
                }
            }

            return res;
        }
    }
}
