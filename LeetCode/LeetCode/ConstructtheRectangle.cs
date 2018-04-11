using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ConstructtheRectangle
    {
        public int[] ConstructRectangle(int area)
        {
            int[] returnValue = new int[2];

            int useValue = (int)Math.Sqrt(area);

            while (area % useValue !=0)
            {
                useValue--;
            }

            returnValue[0] = area / useValue;
            returnValue[1] = useValue;

            return returnValue;
        }
    }
}
