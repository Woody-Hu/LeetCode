using System;
namespace LeetCode
{
	public class find_consecutive_integers_from_a_data_stream
	{
        public class DataStream
        {
            private int _current;

            private int _k;

            private int _count;

            public DataStream(int value, int k)
            {
                _current = value;
                _k = k;
                _count = 0;
            }

            public bool Consec(int num)
            {
                if (num == _current)
                {
                    _count++;
                }
                else
                {
                    _count = 0;
                }

                return _count >= _k;
            }
        }
    }
}

