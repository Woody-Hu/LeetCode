using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class design_an_ordered_stream
    {
        public class OrderedStream
        {

            private int _preIndex = 0;
            private string[] _dic;

            public OrderedStream(int n)
            {
                _dic = new string[n];
            }

            public IList<string> Insert(int idKey, string value)
            {
                var res = new List<string>();
                _dic[idKey-1] = value;
                var i = _preIndex;
                for (; i < _dic.Length; i++)
                {
                    if (_dic[i] == null)
                    {
                        break;
                    }
                    else
                    {
                        res.Add(_dic[i]);
                    }
                }

                if (_preIndex != i)
                {
                    _preIndex = i;
                }

                return res;
            }
        }
    }
}

