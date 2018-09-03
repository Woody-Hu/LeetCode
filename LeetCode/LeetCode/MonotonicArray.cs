using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            if (A.Length < 3)
            {
                return true;
            }

            bool? tag = null;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == A[i+1])
                {
                    continue;
                }
                else
                {
                    if (A[i] > A[i+1])
                    {
                        if (null == tag)
                        {
                            tag = true;
                        }
                        else if (tag.Value == false)
                        {
                            return false;
                        }

                    }
                    else
                    {
                        if (null == tag)
                        {
                            tag = false;
                        }
                        else if (tag.Value == true)
                        {
                            return false;
                        }

                    }
                }
            }

            return true;
        }
    }
}
