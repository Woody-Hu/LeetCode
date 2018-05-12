using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class StudentAttendanceRecordI
    {
        public bool CheckRecord(string s)
        {
            int aCount = 0;
            int nowLCount = 0;

            foreach (var oneChar in s)
            {
                if (oneChar == 'L')
                {
                    nowLCount++;
                    if (nowLCount > 2)
                    {
                        return false;
                    }
                }
                else
                {
                    nowLCount = 0;

                    if (oneChar == 'A')
                    {
                        aCount++;

                        if (aCount > 1)
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
