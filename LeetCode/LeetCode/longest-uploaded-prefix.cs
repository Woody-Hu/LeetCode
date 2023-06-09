using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class longest_uploaded_prefix
	{
        public class LUPrefix
        {
            private int _x = 0;

            private HashSet<int> _set = new HashSet<int>();

            public LUPrefix(int n)
            {

            }

            public void Upload(int video)
            {
                _set.Add(video);
            }

            public int Longest()
            {
                while (_set.Contains(_x + 1))
                {
                    _x++;
                }

                return _x;
            }
        }
    }
}

