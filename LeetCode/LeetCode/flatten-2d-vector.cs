using System;
using System.Linq;

namespace LeetCode
{
	public class flatten_2d_vector
	{
		public flatten_2d_vector()
		{
		}

        public class Vector2D
        {
            private int[][] _data;
            private int _row = 0;
            private int _column = 0;

            public Vector2D(int[][] vec)
            {
                _data = vec;
                SkipEmptyRow();
            }

            public int Next()
            {
                var res = _data[_row][_column];
                _column++;
                if (_column >= _data[_row].Length)
                {
                    _row++;
                    SkipEmptyRow();
                    _column = 0;
                }

                return res;
            }

            public bool HasNext()
            {
                return _row < _data.Length && _column < _data[_row].Length;
            }

            private void SkipEmptyRow()
            {
                while (_row < _data.Length && !_data[_row].Any())
                {
                    _row++;
                }
            }
        }
    }
}

