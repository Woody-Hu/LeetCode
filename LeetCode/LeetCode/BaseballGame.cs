using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BaseballGame
    {
        public int CalPoints(string[] ops)
        {
            List<int> tempValues = new List<int>();
            

            foreach (var oneS in ops)
            {
                if (oneS.Equals("C"))
                {
                    tempValues.RemoveAt(tempValues.Count - 1);
                }
                else if (oneS.Equals("D"))
                {
                    tempValues.Add(2 * tempValues.ElementAt(tempValues.Count - 1));
                }
                else if (oneS.Equals("+"))
                {
                    tempValues.Add(tempValues.ElementAt(tempValues.Count - 1) + tempValues.ElementAt(tempValues.Count - 2));
                }
                else
                {
                    tempValues.Add(int.Parse(oneS));
                }
            }

            return tempValues.Sum();
        }
    }
}
