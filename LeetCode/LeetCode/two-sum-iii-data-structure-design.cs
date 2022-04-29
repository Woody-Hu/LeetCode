using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class two_sum_iii_data_structure_design
    {
        public class TwoSum
        {
            private readonly Dictionary<int, int> _dict = new Dictionary<int, int>();

            public TwoSum()
            {

            }

            public void Add(int number)
            {
                if (!_dict.ContainsKey(number))
                {
                    _dict.Add(number, 0);
                }

                _dict[number]++;
            }

            public bool Find(int value)
            {
                foreach (int i in this._dict.Keys)
                {
                    int complement = value - i;
                    if (complement != i)
                    {
                        if (this._dict.ContainsKey(complement))
                            return true;
                    }
                    else
                    {
                        if (this._dict[i] > 1)
                            return true;
                    }
                }
                return false;
            }
        }
    }
}
