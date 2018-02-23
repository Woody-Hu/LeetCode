using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class JudgeRouteCircle
    {
        private const char cU = 'U';
        private const char cD = 'D';
        private const char cL = 'L';
        private const char cR = 'R';

        public bool JudgeCircle(string moves)
        {
            if (moves.Count() == 0)
            {
                return true;
            }

            if (moves.Count() % 2 != 0)
            {
                return false;
            }

            var groupedValue = moves.GroupBy(k => k).ToDictionary(k=>k.Key,k=>k.Count());

            if (groupedValue.Count() %2 != 0)
            {
                return false;
            }

            AddKey(groupedValue, cU);

            AddKey(groupedValue, cD);

            AddKey(groupedValue, cL);

            AddKey(groupedValue, cR);

            if ((groupedValue[cU] != groupedValue[cD]) || (groupedValue[cL] != groupedValue[cR]))
            {
                return false;
            }
            return true;
        }

        private void AddKey(Dictionary<char,int> inputDic,char inputkey)
        {
            if (!inputDic.ContainsKey(inputkey))
            {
                inputDic.Add(inputkey, 0);
            }
        }
    }
}
