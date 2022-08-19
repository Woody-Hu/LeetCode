using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class iterator_for_combination
    {
        public class CombinationIterator
        {
            private List<int> _list = new List<int>();
            private bool _hasNext = true;
            private string _input;
            private int _combinationLength;

            public CombinationIterator(string characters, int combinationLength)
            {
                _input = characters;
                _combinationLength = combinationLength;
                for (int i = 0; i < combinationLength; i++)
                    _list.Add(i);
            }

            public string Next()
            {
                var stringBuilder = new StringBuilder();
                for (int i = 0; i < _combinationLength; i++)
                    stringBuilder.Append(_input[_list[i]]);
                if (_list[_combinationLength - 1] < _input.Length - 1)
                    _list[_combinationLength - 1] += 1;
                else
                {
                    for (int i = _combinationLength - 1; i >= 0; i--)
                    {
                        if (i != 0 && _list[i - 1] < _input.Length - (_combinationLength - i) - 1)
                        {
                            int j;
                            if (_list[i] < _input.Length - (_combinationLength - i))
                            {
                                j = i;
                                _list[i] += 1;
                            }
                            else
                            {
                                j = i - 1;
                                _list[i - 1] += 1;
                            }
                            for (; j < _combinationLength - 1; j++)
                                _list[j + 1] = _list[j] + 1;
                            break;
                        }
                        else if (i == 0 && _list[0] == _input.Length - _combinationLength)
                            _hasNext = false;
                    }
                }

                return stringBuilder.ToString();
            }

            public bool HasNext()
            {
                return _hasNext;
            }
        }
    }
}
