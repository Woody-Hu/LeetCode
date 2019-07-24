using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Random_Flip_Matrix
    {
        private readonly int _n_rows;
        private readonly int _n_cols;
        private readonly int _size;
        private Dictionary<int, int> _dict = new Dictionary<int, int>();
        private Random _random = new Random();
        
        public Random_Flip_Matrix(int n_rows, int n_cols)
        {
            _n_rows = n_rows;
            _n_cols = n_cols;
            _size = _n_rows * _n_cols;
        }

        public int[] Flip()
        {
            while (true)
            {
                var index = (int) (_random.NextDouble() * _size);
                if (!_dict.ContainsKey(index))
                {
                    _dict.Add(index,0);
                    return new[] {index / _n_cols, index % _n_cols };
                }
            }
        }

        public void Reset()
        {
            _dict = new Dictionary<int, int>();
        }
    }
}
