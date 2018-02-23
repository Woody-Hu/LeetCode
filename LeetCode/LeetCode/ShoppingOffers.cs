using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ShoppingOffers
    {
        public int ShoppingOffersMethod(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            int returnValue = int.MaxValue;

            bool errorTag = false;

            for (int indexOfSpecial = 0; indexOfSpecial < special.Count; indexOfSpecial++)
            {
                errorTag = false;
                for (int i = 0; i < needs.Count; i++)
                {
                    var tempValue = needs[i] - special[indexOfSpecial][i];
                    needs[i] = tempValue;
                    if (!errorTag && tempValue < 0)
                    {
                        errorTag = true;
                    }
                }

                if (!errorTag)
                {
                    returnValue = Math.Min(returnValue, ShoppingOffersMethod(price, special, needs) + special[indexOfSpecial][needs.Count]);
                }

                for (int i = 0; i < needs.Count; i++)
                {
                    needs[i] = needs[i] + special[indexOfSpecial][i];
                }
            }

            int nonOfferPrice = 0;
            for (int i = 0; i < needs.Count; i++)
            {
                nonOfferPrice += price[i] * needs[i];
            }
            return Math.Min(returnValue, nonOfferPrice);
        }

       
    }
}
