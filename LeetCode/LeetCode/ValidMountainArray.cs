using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidMountainArray
    {
        public bool ValidMountainArrayMethod(int[] A)
        {
            int? frontValue = null;

            bool front = false;
            bool back = false;

            foreach (var oneValue in A)
            {
                if (null != frontValue)
                {
                    if (frontValue.Value < oneValue)
                    {
                        if (back)
                        {
                            return false;
                        }

                        front = true;
                    }
                    else if (frontValue.Value > oneValue)
                    {
                        if (!front)
                        {
                            return false;
                        }

                        back = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                frontValue = oneValue;
            }

            return front && back;

        }
    }
}
